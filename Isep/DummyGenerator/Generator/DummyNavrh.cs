using Bogus;
using Isep.Model.Dwh;
using System.Runtime.Intrinsics.Arm;


namespace DummyGenerator.Generator
{
    public static class DummyNavrh
    {
        public static IEnumerable<Navrh> Generate(IList<Vav_role_osoba> roles)
        {
            Randomizer.Seed = new Random(8675309);

            var date = DateTime.Now;

            var projektOsoby = new Faker<NAVRH_osoba>()
                    .RuleFor(po => po.Jmeno, f => f.Name.FirstName())
                    .RuleFor(po => po.Prijmeni, f => f.Name.LastName())
                    .RuleFor(po => po.Titul_pred, f => f.PickRandom(GeneratorConfig.titulPred))
                    .RuleFor(po => po.Titul_za, f => f.PickRandomWithRatio(GeneratorConfig.titulZa, GeneratorConfig.DegreesRatio))
                    .RuleFor(po => po.Vav_role, f => f.PickRandom(roles.Where(r => GeneratorConfig.Roles.Contains(r.ROLE_OSOBA_ID))))
                    .RuleFor(po => po.Pohlavi, f => f.PickRandomWithRatio(GeneratorConfig.pohlavi, GeneratorConfig.GenderRatio));

            var projektPracVazba = new Faker<NAVRH_prac_vazba>()
                                    .RuleFor(ppv => ppv.Navrh_osoby, f => projektOsoby.Generate(f.Rant.Random.Int(1, 22)))
                                    .FinishWith((f, ppv) =>
                                    {
                                        var r = f.Random.Int(0, 100);
                                        var man = r < GeneratorConfig.MenInChiefPercent;
                                        var person = ppv.Navrh_osoby.FirstOrDefault(o => man ? o.Pohlavi == "Muz" : o.Pohlavi == "Zena") ?? ppv.Navrh_osoby.First();
                                        person.Vav_role = roles.First(r => r.ROLE_OSOBA_ID == GeneratorConfig.ManagerRole);
                                    });



            var navrhFaker = new Faker<Navrh>()

                            .RuleFor(p => p.Datum_zahajeni, f =>
                            {
                                date = f.Date.Past(8);
                                return date;
                            })
                            .RuleFor(p => p.Datum_ukonceni, f =>
                            {
                                return date.AddMonths(f.Random.Int(6, 18));
                            })
                            .RuleFor(p => p.Datum_navrhu, f =>
                            {
                                return date.AddMonths(-f.Random.Int(6, 8));
                            })
                            .RuleFor(p => p.Navrh_Prac_vazba, f => projektPracVazba.Generate(1).First());

            var rnd = new Random();
            var ds = navrhFaker.Generate(rnd.Next(60, 150));

            foreach (var d in ds)
            {
                d.Navrhovatel_gender = d.Navrh_Prac_vazba.Navrh_osoby.FirstOrDefault(o => o.Vav_role.ROLE_OSOBA_ID == 'H').Pohlavi;
            }

            return ds;
        }
    }
}

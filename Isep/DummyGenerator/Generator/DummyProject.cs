using Bogus;
using Isep.Model.Dwh;


namespace DummyGenerator.Generator
{
    public static class DummyProject
    {
        private static string mena = string.Empty;
        private static int divider
        {
            get
            {
                return mena == "CZK" ? 1 : 25;
            }
        }

        public static IEnumerable<Projekt> Generate(IList<Vav_role_osoba> roles)
        {
            Randomizer.Seed = new Random(8675309);
            
            var date = DateTime.Now;

            var projektOsoby = new Faker<Projekt_Osoba>()
                    .RuleFor(po => po.Jmeno, f => f.Name.FirstName())
                    .RuleFor(po => po.Prijmeni, f => f.Name.LastName())
                    .RuleFor(po => po.Titul_pred, f => f.PickRandom(GeneratorConfig.titulPred))
                    .RuleFor(po => po.Titul_za, f => f.PickRandomWithRatio(GeneratorConfig.titulZa, GeneratorConfig.DegreesRatio))
                    .RuleFor(po => po.Vav_role, f => f.PickRandom(roles.Where(r => GeneratorConfig.Roles.Contains(r.ROLE_OSOBA_ID))))
                    .RuleFor(po => po.Pohlavi, f => f.PickRandomWithRatio(GeneratorConfig.pohlavi, GeneratorConfig.GenderRatio));

            var projektPracVazba = new Faker<Projekt_prac_vazba>()
                                    .RuleFor(ppv => ppv.Projekt_osoby, f => projektOsoby.Generate(f.Rant.Random.Int(1, 22)))
                                    .FinishWith((f, ppv) =>
                                    {
                                        var r = f.Random.Int(0, 100);
                                        var man = r < GeneratorConfig.MenInChiefPercent;
                                        var person = ppv.Projekt_osoby.FirstOrDefault(o => man ? o.Pohlavi == "Muz" : o.Pohlavi == "Zena") ?? ppv.Projekt_osoby.First();
                                        person.Vav_role = roles.First(r => r.ROLE_OSOBA_ID == GeneratorConfig.ManagerRole);
                                    });

            var radekFaker = new Faker<Projekt_rozpocet_radek>()
                            .RuleFor(r => r.Cinnost, f => "Cinnost")
                            .RuleFor(r => r.N_Investicni, f => f.Random.Decimal(1000 / divider, 100000 / divider))
                            .RuleFor(r => r.N_Neinvesticni, f => f.Random.Int(1000 / divider, 100000 / divider))
                            .RuleFor(r => r.Rok, f => date.Year);

            var rozpocetFaker = new Faker<Projekt_rozpocet>()
                            .RuleFor(p => p.Mena, f =>
                            {
                                mena = f.PickRandom(GeneratorConfig.mena);
                                return mena;
                            })
                            .RuleFor(p => p.Platnost_od, f => date)
                            .RuleFor(p => p.Rozpocet_radky, f => radekFaker.Generate(f.Random.Int(1, 4)));


            var testprojects = new Faker<Projekt>()
                            .RuleFor(p => p.Datum_zahajeni, f =>
                            {
                                date = f.Date.Past(8);
                                return date;
                            })
                            .RuleFor(p => p.Datum_ukonceni, f =>
                            {
                                return date.AddMonths(f.Random.Int(6, 18));
                            })
                            .RuleFor(p => p.Projekt_prac_vazba, f => projektPracVazba.Generate(1).First())
                            .RuleFor(p => p.Rozpocet, f => rozpocetFaker.Generate(f.Random.Int(1, 2)));

            var rnd = new Random();
            var dp = testprojects.Generate(rnd.Next(60, 150));

            foreach (var p in dp)
            {
                p.Gender = p.Projekt_prac_vazba.Projekt_osoby.FirstOrDefault(o => o.Vav_role.ROLE_OSOBA_ID == 'H').Pohlavi;
            }

            return dp;
        }
    }
}

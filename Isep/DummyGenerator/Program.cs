using Isep;
using DummyGenerator.Generator;
using Microsoft.EntityFrameworkCore;
using Isep.Model.Dwh;


using (var context = new IsepDbContext())
{
    try
    {
        Console.WriteLine("Deleting old database.");
        File.Delete("Database.db");
        Console.WriteLine("Migrationg new database.");
        context.Database.Migrate();
        Console.WriteLine("Done.");

        var roles = context.Vav_role.ToList();

        Console.WriteLine("Generationg dummy projects.");
        var dummyProjekt = DummyProject.Generate(roles);
        Console.WriteLine("Done.");
        Console.WriteLine("Generationg dummy drafts.");
        var dummyNavrh = DummyNavrh.Generate(roles).ToList();
        Console.WriteLine("Done.");


       

        Console.WriteLine("Adding new projects.");
        context.Projekt.AddRange(dummyProjekt);
        Console.WriteLine("Adding new drafts.");
        context.Navrh.AddRange(dummyNavrh);
        Console.WriteLine("Done.");

        Console.WriteLine("Saving changes.");
        context.SaveChanges();

        Console.WriteLine("Generating drafts for existings projects");
        var draftProjekt = new Dictionary<Projekt, Navrh>();
        foreach (var projekt in dummyProjekt)
        {
            draftProjekt.Add(projekt, projekt.ToDraft());
        }

        Console.WriteLine("Saving new drafts");
        context.Navrh.AddRange(draftProjekt.Values);
        context.SaveChanges();

        Console.WriteLine("Updating projects");
        foreach (var p in draftProjekt)
        {
            p.Key.Navrh_Id = p.Value.Navrh_Id;
        }

        context.SaveChanges(true);
        Console.WriteLine("Done.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

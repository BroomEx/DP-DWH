using Isep.Model.Shared;
using System.ComponentModel.DataAnnotations;


namespace Isep.Model.Dwh
{
    public class Projekt_prac_vazba  
    {
        [Key]
        public int Projekt_prac_vazba_Id { get; set; }
        public int Projekt_Id { get; set; }
        public virtual Projekt Projekt { get; set; }
        public ICollection<Projekt_Osoba> Projekt_osoby { get; set; }
    }
}

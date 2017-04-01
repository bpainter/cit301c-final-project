using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace cit301C_final_project.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string SerialNum { get; set; }
        public string AnimalCategory { get; set; }
        public string AnimalName { get; set; }

        [Display(Name = "Pet's Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        public string Breed { get; set; }
        public string OwnerName { get; set; }
        public string OwnerStreet { get; set; }
        public string OwnerState { get; set; }
        public string OwnerZip { get; set; }
        public string OwnerPhoneNum { get; set; }
        public string PhotoUrl { get; set; }
    }
    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pet { get; set; }
    }
}
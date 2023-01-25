namespace Övning14.Models
{
    public class ApplicationUserGymClass
    {
        public int Id { get; set; }

        //[Required]
        //public string title { get; set; }

        //[Required]
        //[StringLength(255)]
        //public string message { get; set; }

        //public ApplicationUser ApplicationUserID { get; set; }
        //public ApplicationUser applicationUser { get; set; }
        //public GymClass GymClassID { get; set; }
        //public GymClass gymClass { get; set; }
        public int ApplicationUserId { get; set; }
        public int GymClassId { get; set; }

        //public ICollection<ApplicationUser> ApplicationUsers { get; set; }
        //public ICollection<GymClass> GymClasses { get; set; }
    }
}

using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace TimeFormat
{
    public class DataFormModel
    {
        [Display(Name = "Name", Prompt = "First name")]
        public string FirstName { get; set; }

        [Display(Prompt = "Last name")]
        public string LastName { get; set; }

        public Gender Gender { get; set; }

        [Display(Prompt = "Select an event")]
        public string Event { get; set; }

        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }

        [Display(Name = "Event Time")]
        public TimeSpan? EventTime { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
}
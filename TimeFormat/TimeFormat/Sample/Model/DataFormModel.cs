using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace TimeFormat
{
    public class DataFormModel
    {
        [Display(Name = "Name", Prompt = "First name")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Prompt = "Last name")]
        public string LastName { get; set; } = string.Empty;

        public Gender Gender { get; set; }

        [Display(Prompt = "Select an event")]
        public string Event { get; set; } = string.Empty;

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
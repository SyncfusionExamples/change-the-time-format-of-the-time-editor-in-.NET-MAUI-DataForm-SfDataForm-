using Syncfusion.Maui.DataForm;

namespace TimeFormat
{
    public class ItemSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "Event")
            {
                List<string> events = new List<string>();

                events.Add("Hackathon");
                events.Add("Innovation program");
                events.Add("Tech Spotlight");
                return events;
            }

            return new List<string>();
        }
    }
}
namespace EcoHub.Models
{
   // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Result
    {
        public List<Tags> tags { get; set; }
    }

    public class Root
    {
        public Result result { get; set; }
        public Status status { get; set; }
    }

    public class Status
    {
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Tags
    {
        public double confidence { get; set; }
        public Tag tag { get; set; }
    }

    public class Tag
    {
        public string en { get; set; }
    }
}

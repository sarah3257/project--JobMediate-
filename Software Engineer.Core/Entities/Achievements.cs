namespace Software_Engineer.Core.Entities
{
    public class Achievements:BaseModel
    {
        public string? Name { get; set; }
        public List<Projects> projects { get; set; }

    }
}

namespace Software_Engineer.Core.Entities
{
    public class Projects:BaseModel
    {
       public string? NameProject { get; set; }
        public DateTime? CreationDate { get; set; }
        public int AchievementId { get; set; }
        public Achievements Achievement { get; set; }
    }

}

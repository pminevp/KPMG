namespace CF.Models
{
    public class ComputerPart
    {
        public int id { get; set; }
        public string PartName { get; set; }
        public string Description { get; set; }
        public string PartType { get; set; }
        public int PartTypeId { get; set; }
        public double Price { get; set; }

    }
}

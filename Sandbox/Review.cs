namespace Sandbox
{
    public class Review
    {
        public int Id { get; set; }
        public decimal Rating { get; set; }
        public int ItemId { get; set; }
        public string ReviewText { get; set; }
        public string Reviewer { get; set; }
    }
}
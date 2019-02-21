namespace Utilities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Category)}: {Category}, {nameof(Description)}: {Description}, {nameof(Image)}: {Image}, {nameof(Price)}: {Price}";
        }
    }
  
}
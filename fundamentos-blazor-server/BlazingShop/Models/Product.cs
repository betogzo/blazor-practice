namespace BlazingShop.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int id, string name, string description, int categoryId, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            //Category = category;
            CategoryId = categoryId;
            Price = price;
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public Category Category { get; set; }
        public decimal Price { get; set; }
    }
}

using system;
namespace Product
{
	 class Product
    {
        internal int productId;
        internal string productName;
        internal double price;
        internal string color;

        internal void Display()
        {
            Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        }
		internal Product()
        {
            Console.WriteLine("Empty Object Initialization");
        }
        internal Product(int productId, string productName, double price, string color)
        {
            Console.WriteLine("Object Initialized");
            this.productId = productId;
            this.productName = productName;
            this.color = color;
            this.price = price;
                 
        }
    }
	class ProductMoodel
	{
		static void main(string[] args)
		{
			product1 = new product;
			product1.productID = 1450;
			product1.productName = "Pendrive";
			product1.price = 450;
			product1.color = "Blue";
			
			product1.Display();
			product2 = new product(123, "Mouse", 599, "red");
			product2.Display();
		}
	}
} 

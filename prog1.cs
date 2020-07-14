
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
    }
	class ProductMoodel
	{
		static void main(string[] args)
		{
			product1=new product;
			product1.productID = 143;
			product1.productName = "washingmachine";
			product1.price = 45000;
			product1.color = "Blue";
			
			product1.Display();
		}
	}
}

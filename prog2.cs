
using system;
namespace Product
{
	 class Product
    {
        int productId;
        string productName;
        double price;
        string color;

        void Display()
        {
            Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        }
		static void main(string[] args)
		{
			product1=new product;
			product1.productID = 1298;
			product1.productName = "mouse";
			product1.price = 499;
			product1.color = "black";
			
			product1.Display();
		}
    }
	class ProductMoodel
	{
		static void main(string[] args)
		{
			product1=new product;
			product1.productID = 1450;
			product1.productName = "pendrive";
			product1.price = 450;
			product1.color = "Red";
			
			product1.Display();
		}
	}
}

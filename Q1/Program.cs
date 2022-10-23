using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create List
			List<Product> products = new List<Product>();

			// Create product
			Product algorithm = new Product()
			{
				Id = "B0001",
				Name = "Intoduction to Algoritm",
				Price = 1500,
				Category = "TextBook",
				Description = "聖經本值得推薦"
			};

			Product os = new Product()
			{
				Id = "B0002",
				Name = "Operating System Concepts",
				Price = 1300,
				Category = "TextBook",
				Description = "俗稱恐龍本, 是一本很好的書"
			};

			Product pencil = new Product()
			{
				Id = "S0001",
				Name = "Pencil",
				Price = 10,
				Category = "stationery",
				Description = "便宜又好用, 讚讚讚"
			};

			Product toothBrush = new Product()
			{
				Id = "T0001",
				Name = "ToothBrush",
				Price = 40,
				Category = "Toiletries",
				Description = "不刷牙就會蛀牙喔, 每天都要刷牙"
			};

			//Add to List
			products.Add(algorithm);   
			products.Add(os);
			products.Add(pencil);
			products.Add(toothBrush);

			// Remove from List
			products.Remove(algorithm);
			products.Remove(os);
			products.Remove(pencil);
			products.Remove(toothBrush);
		}
	}

	class Product
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
	}
}

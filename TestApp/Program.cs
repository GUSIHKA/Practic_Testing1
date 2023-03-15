using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
	internal class Program
	{
        private static int width;

        static void Main(string[] args)
		{
			Class1 Calculator = new Class1();

			int productType = 1;
			int materialType = 1;
			int count = 20;
            float width = 45.0f; 
			float length = 30.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			Console.ReadKey();


		}
	}
}

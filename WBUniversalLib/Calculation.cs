using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;


namespace WBUniversalLib
{
	[TestClass]
	public class Calculation
	{
	
		[TestMethod]
		public void Calculation_ValidData()
		{
            Class1 Calculator = new Class1();

			int productType = -1;
			int materialType = 0;
			int count = 15;
			float width = 45.0f;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualQuantity = -1;
			Assert.AreEqual(materialCount, actualQuantity);

		}


		[TestMethod]
		public void Calculation_ProductTypeLessThanZero() 
		{
            Class1 Calculator = new Class1();

			int productType = -1;
			int materialType = 0;
			int count = 15;
			float width = 45.0f;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;
			Assert.AreEqual(materialCount, actualResult);

		}
		[TestMethod]
		public void Calculation_MaterialTypeLessThanZero()
		{
            Class1 Calculator = new Class1();

			int productType = 0;
			int materialType = -1;
			int count = 15;
			float width = 45.0f;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;
			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_ProductTypeMoreThanMaximum()
		{
            Class1 Calculator = new Class1();

			int productType = 9;
			int materialType = 0;
			int count = 15;
			float width = 45.0f;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;
			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_MaterialTypeMoreThanMaximum()
		{
            Class1 Calculator = new Class1();

			int productType = 0;
			int materialType = 9;
			int count = 15;
			float width = 45.0f;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;
			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_CountIsLessThanZero()
		{
            Class1 Calculator = new Class1();

			int productType = 0;
			int materialType = 0;
			int count = -9;
			float width = 45.0f;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;
			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_CountIsZero()
		{
            Class1 Calculator = new Class1();

			int productType = 0;
			int materialType = 0;
			int count = 0;
			float width = 45.0f;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;
			Assert.AreEqual(materialCount, actualResult);
		}

		[TestMethod]
		public void Calculation_WidthIsLessThanZero()
		{
            Class1 Calculator = new Class1();

			int productType = 0;
			int materialType = 0;
			int count = -15;
			float width = -9.0f;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;
			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_WidthIsZero() {
            Class1 Calculator = new Class1();

			int productType =0, materialType = 0;
			int count = -15;
			float width = 0.0f;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;
			Assert.AreEqual(materialCount, actualResult);

		}

		[TestMethod]
		public void Calculation_ResultOverflow() {
            Class1 Calculator = new Class1();
			int productType =0, materialType = 0;
			int count = 4;
			float width = float.MaxValue;
			float length = 20.0f;

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)length);
			Console.WriteLine($"{materialCount}");

			int actualResult = -1;
			Assert.AreEqual(materialCount, actualResult);

		}

	}

}

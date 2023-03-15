using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp;

namespace CalculatorForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void numProductNumber_ValueChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void numWidth_ValueChanged(object sender, EventArgs e)
		{

		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			Class1 Calculator = new Class1();

			int productType = Convert.ToInt16(numProductNumber.Value);
			int materialType = Convert.ToInt16(numMaterialNumber.Value);
			int count = Convert.ToInt16(numCount.Value);
			float width = Convert.ToInt16(numWidth.Value);
			float lenght = Convert.ToInt16(numHeight.Value);

			int materialCount = Calculator.CalculateRawMaterial(productType, materialType, count, (int)width, (int)lenght);
			labelItog.Text = $"Итог: {materialCount}";
		}
	}
}

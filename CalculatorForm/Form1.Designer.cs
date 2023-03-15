namespace CalculatorForm
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.numWidth = new System.Windows.Forms.NumericUpDown();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numHeight = new System.Windows.Forms.NumericUpDown();
			this.numProductNumber = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numMaterialNumber = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.numCount = new System.Windows.Forms.NumericUpDown();
			this.labelItog = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numProductNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaterialNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, -9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 1;
			// 
			// numWidth
			// 
			this.numWidth.DecimalPlaces = 6;
			this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numWidth.Location = new System.Drawing.Point(16, 84);
			this.numWidth.Name = "numWidth";
			this.numWidth.Size = new System.Drawing.Size(253, 26);
			this.numWidth.TabIndex = 2;
			this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCalculate.Location = new System.Drawing.Point(40, 314);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(159, 48);
			this.btnCalculate.TabIndex = 3;
			this.btnCalculate.Text = "Рассчитать";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ширина";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Высота";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// numHeight
			// 
			this.numHeight.DecimalPlaces = 6;
			this.numHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numHeight.Location = new System.Drawing.Point(16, 145);
			this.numHeight.Name = "numHeight";
			this.numHeight.Size = new System.Drawing.Size(253, 26);
			this.numHeight.TabIndex = 5;
			this.numHeight.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// numProductNumber
			// 
			this.numProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numProductNumber.Location = new System.Drawing.Point(16, 209);
			this.numProductNumber.Name = "numProductNumber";
			this.numProductNumber.Size = new System.Drawing.Size(253, 26);
			this.numProductNumber.TabIndex = 7;
			this.numProductNumber.ValueChanged += new System.EventHandler(this.numProductNumber_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Номер типа продукта";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(187, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Номер типа материала";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// numMaterialNumber
			// 
			this.numMaterialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numMaterialNumber.Location = new System.Drawing.Point(16, 263);
			this.numMaterialNumber.Name = "numMaterialNumber";
			this.numMaterialNumber.Size = new System.Drawing.Size(253, 26);
			this.numMaterialNumber.TabIndex = 9;
			this.numMaterialNumber.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Кол-во продукции";
			// 
			// numCount
			// 
			this.numCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numCount.Location = new System.Drawing.Point(16, 32);
			this.numCount.Name = "numCount";
			this.numCount.Size = new System.Drawing.Size(253, 26);
			this.numCount.TabIndex = 11;
			// 
			// labelItog
			// 
			this.labelItog.AutoSize = true;
			this.labelItog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelItog.Location = new System.Drawing.Point(316, 160);
			this.labelItog.Name = "labelItog";
			this.labelItog.Size = new System.Drawing.Size(58, 24);
			this.labelItog.TabIndex = 13;
			this.labelItog.Text = "Итог:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 385);
			this.Controls.Add(this.labelItog);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numCount);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.numMaterialNumber);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numProductNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numHeight);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.numWidth);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Рассчет кол-ва материала";
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numProductNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaterialNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numWidth;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numHeight;
		private System.Windows.Forms.NumericUpDown numProductNumber;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numMaterialNumber;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numCount;
		private System.Windows.Forms.Label labelItog;
	}
}


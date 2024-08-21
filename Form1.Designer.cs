namespace ExchangeRate
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.inputCurrency = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.inputUAH = new System.Windows.Forms.TextBox();
			this.infoButton = new System.Windows.Forms.Button();
			this.calculateButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// inputCurrency
			// 
			this.inputCurrency.BackColor = System.Drawing.Color.White;
			this.inputCurrency.Location = new System.Drawing.Point(25, 85);
			this.inputCurrency.Name = "inputCurrency";
			this.inputCurrency.Size = new System.Drawing.Size(394, 27);
			this.inputCurrency.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(29, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 31);
			this.label1.TabIndex = 3;
			this.label1.Text = "Введіть назву валюти";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(25, 243);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(505, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "Введіть суму гривень, яку хочете конвертувати\r\n";
			// 
			// inputUAH
			// 
			this.inputUAH.BackColor = System.Drawing.Color.White;
			this.inputUAH.Location = new System.Drawing.Point(25, 279);
			this.inputUAH.Name = "inputUAH";
			this.inputUAH.Size = new System.Drawing.Size(394, 27);
			this.inputUAH.TabIndex = 6;
			// 
			// infoButton
			// 
			this.infoButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.infoButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.infoButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.infoButton.Location = new System.Drawing.Point(443, 82);
			this.infoButton.Name = "infoButton";
			this.infoButton.Size = new System.Drawing.Size(219, 30);
			this.infoButton.TabIndex = 7;
			this.infoButton.Text = "Завантажити";
			this.infoButton.UseVisualStyleBackColor = false;
			this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
			// 
			// calculateButton
			// 
			this.calculateButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.calculateButton.ForeColor = System.Drawing.SystemColors.InfoText;
			this.calculateButton.Location = new System.Drawing.Point(443, 277);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(219, 29);
			this.calculateButton.TabIndex = 8;
			this.calculateButton.Text = "Розрахувати";
			this.calculateButton.UseVisualStyleBackColor = false;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(29, 311);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 28);
			this.label2.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(29, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 28);
			this.label4.TabIndex = 10;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.Red;
			this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Location = new System.Drawing.Point(677, 12);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(27, 29);
			this.closeButton.TabIndex = 11;
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(716, 365);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.infoButton);
			this.Controls.Add(this.inputUAH);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputCurrency);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Курс Валют";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private TextBox inputCurrency;
		private Label label1;
		private Label label3;
		private TextBox inputUAH;
		private Button infoButton;
		private Button calculateButton;
		private Label label2;
		private Label label4;
		private Button closeButton;
	}
}
namespace Key_Service
{
	partial class KeyServiceForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyServiceForm));
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.buttonSaveToFile = new System.Windows.Forms.Button();
			this.buttonCopyToClipboard = new System.Windows.Forms.Button();
			this.buttonGenerateKey = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(131, 13);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(184, 17);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "lateinische Kleinbuchstaben [a..z]";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(131, 36);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(187, 17);
			this.checkBox2.TabIndex = 5;
			this.checkBox2.Text = "lateinische Großbuchstaben [A..Z]";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(131, 59);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(98, 17);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.Text = "Nummern [0..9]";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(131, 82);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(100, 17);
			this.checkBox4.TabIndex = 7;
			this.checkBox4.Text = "Sonderzeichen:";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Länge:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(58, 11);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(73, 114);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(186, 20);
			this.textBox1.TabIndex = 10;
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(237, 80);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(78, 20);
			this.textBox.TabIndex = 8;
			this.textBox.Text = ".,;:-_=+()[]{}<>?!#$%&*/|\\@^\'~\"";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Schlüssel:";
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(15, 37);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(105, 17);
			this.checkBox5.TabIndex = 2;
			this.checkBox5.Text = "Zeichen-Unikate";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// buttonSaveToFile
			// 
			this.buttonSaveToFile.Image = global::KeyService.Properties.Resources.filesave_16;
			this.buttonSaveToFile.Location = new System.Drawing.Point(293, 114);
			this.buttonSaveToFile.Name = "buttonSaveToFile";
			this.buttonSaveToFile.Size = new System.Drawing.Size(22, 22);
			this.buttonSaveToFile.TabIndex = 12;
			this.buttonSaveToFile.UseVisualStyleBackColor = true;
			// 
			// buttonCopyToClipboard
			// 
			this.buttonCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyToClipboard.Image")));
			this.buttonCopyToClipboard.Location = new System.Drawing.Point(265, 114);
			this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
			this.buttonCopyToClipboard.Size = new System.Drawing.Size(22, 22);
			this.buttonCopyToClipboard.TabIndex = 11;
			this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
			// 
			// buttonGenerateKey
			// 
			this.buttonGenerateKey.Image = global::KeyService.Properties.Resources.KeyService_32;
			this.buttonGenerateKey.Location = new System.Drawing.Point(12, 59);
			this.buttonGenerateKey.Name = "buttonGenerateKey";
			this.buttonGenerateKey.Size = new System.Drawing.Size(108, 40);
			this.buttonGenerateKey.TabIndex = 3;
			this.buttonGenerateKey.Text = "Schlüssel erzeugen";
			this.buttonGenerateKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonGenerateKey.UseVisualStyleBackColor = true;
			// 
			// KeyServiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 146);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.buttonSaveToFile);
			this.Controls.Add(this.buttonCopyToClipboard);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.buttonGenerateKey);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "KeyServiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Schlüsseldienst";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonGenerateKey;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCopyToClipboard;
		private System.Windows.Forms.Button buttonSaveToFile;
		private System.Windows.Forms.CheckBox checkBox5;
	}
}


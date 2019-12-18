namespace KeyService
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
			this.checkBoxLittleChars = new System.Windows.Forms.CheckBox();
			this.checkBoxBigChars = new System.Windows.Forms.CheckBox();
			this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
			this.checkBoxSonderzeichen = new System.Windows.Forms.CheckBox();
			this.labelLength = new System.Windows.Forms.Label();
			this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
			this.textBoxKey = new System.Windows.Forms.TextBox();
			this.textBoxSonderzeichen = new System.Windows.Forms.TextBox();
			this.labelKey = new System.Windows.Forms.Label();
			this.checkBoxUnicat = new System.Windows.Forms.CheckBox();
			this.buttonSaveToFile = new System.Windows.Forms.Button();
			this.buttonCopyToClipboard = new System.Windows.Forms.Button();
			this.buttonGenerateKey = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBoxLittleChars
			// 
			this.checkBoxLittleChars.AutoSize = true;
			this.checkBoxLittleChars.Location = new System.Drawing.Point(131, 13);
			this.checkBoxLittleChars.Name = "checkBoxLittleChars";
			this.checkBoxLittleChars.Size = new System.Drawing.Size(184, 17);
			this.checkBoxLittleChars.TabIndex = 4;
			this.checkBoxLittleChars.Text = "lateinische Kleinbuchstaben [a..z]";
			this.checkBoxLittleChars.UseVisualStyleBackColor = true;
			// 
			// checkBoxBigChars
			// 
			this.checkBoxBigChars.AutoSize = true;
			this.checkBoxBigChars.Location = new System.Drawing.Point(131, 36);
			this.checkBoxBigChars.Name = "checkBoxBigChars";
			this.checkBoxBigChars.Size = new System.Drawing.Size(187, 17);
			this.checkBoxBigChars.TabIndex = 5;
			this.checkBoxBigChars.Text = "lateinische Großbuchstaben [A..Z]";
			this.checkBoxBigChars.UseVisualStyleBackColor = true;
			// 
			// checkBoxNumbers
			// 
			this.checkBoxNumbers.AutoSize = true;
			this.checkBoxNumbers.Location = new System.Drawing.Point(131, 59);
			this.checkBoxNumbers.Name = "checkBoxNumbers";
			this.checkBoxNumbers.Size = new System.Drawing.Size(98, 17);
			this.checkBoxNumbers.TabIndex = 6;
			this.checkBoxNumbers.Text = "Nummern [0..9]";
			this.checkBoxNumbers.UseVisualStyleBackColor = true;
			// 
			// checkBoxSonderzeichen
			// 
			this.checkBoxSonderzeichen.AutoSize = true;
			this.checkBoxSonderzeichen.Location = new System.Drawing.Point(131, 82);
			this.checkBoxSonderzeichen.Name = "checkBoxSonderzeichen";
			this.checkBoxSonderzeichen.Size = new System.Drawing.Size(100, 17);
			this.checkBoxSonderzeichen.TabIndex = 7;
			this.checkBoxSonderzeichen.Text = "Sonderzeichen:";
			this.checkBoxSonderzeichen.UseVisualStyleBackColor = true;
			// 
			// labelLength
			// 
			this.labelLength.AutoSize = true;
			this.labelLength.Location = new System.Drawing.Point(12, 14);
			this.labelLength.Name = "labelLength";
			this.labelLength.Size = new System.Drawing.Size(40, 13);
			this.labelLength.TabIndex = 0;
			this.labelLength.Text = "Länge:";
			// 
			// numericUpDownLength
			// 
			this.numericUpDownLength.Location = new System.Drawing.Point(58, 11);
			this.numericUpDownLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownLength.Name = "numericUpDownLength";
			this.numericUpDownLength.Size = new System.Drawing.Size(48, 20);
			this.numericUpDownLength.TabIndex = 1;
			this.numericUpDownLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownLength.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// textBoxKey
			// 
			this.textBoxKey.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxKey.Location = new System.Drawing.Point(73, 114);
			this.textBoxKey.Name = "textBoxKey";
			this.textBoxKey.Size = new System.Drawing.Size(186, 20);
			this.textBoxKey.TabIndex = 10;
			// 
			// textBoxSonderzeichen
			// 
			this.textBoxSonderzeichen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSonderzeichen.Location = new System.Drawing.Point(237, 80);
			this.textBoxSonderzeichen.Name = "textBoxSonderzeichen";
			this.textBoxSonderzeichen.Size = new System.Drawing.Size(78, 20);
			this.textBoxSonderzeichen.TabIndex = 8;
			this.textBoxSonderzeichen.Text = ".,;:-_=+()[]{}<>?!#$%&*/|\\@^\'~\"";
			// 
			// labelKey
			// 
			this.labelKey.AutoSize = true;
			this.labelKey.Location = new System.Drawing.Point(12, 117);
			this.labelKey.Name = "labelKey";
			this.labelKey.Size = new System.Drawing.Size(55, 13);
			this.labelKey.TabIndex = 9;
			this.labelKey.Text = "Schlüssel:";
			// 
			// checkBoxUnicat
			// 
			this.checkBoxUnicat.AutoSize = true;
			this.checkBoxUnicat.Location = new System.Drawing.Point(15, 37);
			this.checkBoxUnicat.Name = "checkBoxUnicat";
			this.checkBoxUnicat.Size = new System.Drawing.Size(105, 17);
			this.checkBoxUnicat.TabIndex = 2;
			this.checkBoxUnicat.Text = "Zeichen-Unikate";
			this.checkBoxUnicat.UseVisualStyleBackColor = true;
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
			this.Controls.Add(this.checkBoxUnicat);
			this.Controls.Add(this.buttonSaveToFile);
			this.Controls.Add(this.buttonCopyToClipboard);
			this.Controls.Add(this.labelKey);
			this.Controls.Add(this.textBoxSonderzeichen);
			this.Controls.Add(this.textBoxKey);
			this.Controls.Add(this.numericUpDownLength);
			this.Controls.Add(this.labelLength);
			this.Controls.Add(this.checkBoxSonderzeichen);
			this.Controls.Add(this.checkBoxNumbers);
			this.Controls.Add(this.checkBoxBigChars);
			this.Controls.Add(this.checkBoxLittleChars);
			this.Controls.Add(this.buttonGenerateKey);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "KeyServiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Schlüsseldienst";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonGenerateKey;
		private System.Windows.Forms.CheckBox checkBoxLittleChars;
		private System.Windows.Forms.CheckBox checkBoxBigChars;
		private System.Windows.Forms.CheckBox checkBoxNumbers;
		private System.Windows.Forms.CheckBox checkBoxSonderzeichen;
		private System.Windows.Forms.Label labelLength;
		private System.Windows.Forms.NumericUpDown numericUpDownLength;
		private System.Windows.Forms.TextBox textBoxKey;
		private System.Windows.Forms.TextBox textBoxSonderzeichen;
		private System.Windows.Forms.Label labelKey;
		private System.Windows.Forms.Button buttonCopyToClipboard;
		private System.Windows.Forms.Button buttonSaveToFile;
		private System.Windows.Forms.CheckBox checkBoxUnicat;
	}
}


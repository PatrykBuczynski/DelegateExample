namespace DelegateExample
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.DialogCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveToFileCheckBox = new System.Windows.Forms.CheckBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.oneArgumentRadioButton = new System.Windows.Forms.RadioButton();
            this.twoArgumentsRadioButton = new System.Windows.Forms.RadioButton();
            this.firstArgumentTextBox = new System.Windows.Forms.TextBox();
            this.secondArgumentTextBox = new System.Windows.Forms.TextBox();
            this.mathComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogCheckBox
            // 
            this.DialogCheckBox.AutoSize = true;
            this.DialogCheckBox.Location = new System.Drawing.Point(42, 89);
            this.DialogCheckBox.Name = "DialogCheckBox";
            this.DialogCheckBox.Size = new System.Drawing.Size(86, 17);
            this.DialogCheckBox.TabIndex = 0;
            this.DialogCheckBox.Text = "Show Dialog";
            this.DialogCheckBox.UseVisualStyleBackColor = true;
            this.DialogCheckBox.CheckedChanged += new System.EventHandler(this.DialogCheckBox_CheckedChanged);
            // 
            // SaveToFileCheckBox
            // 
            this.SaveToFileCheckBox.AutoSize = true;
            this.SaveToFileCheckBox.Location = new System.Drawing.Point(42, 112);
            this.SaveToFileCheckBox.Name = "SaveToFileCheckBox";
            this.SaveToFileCheckBox.Size = new System.Drawing.Size(86, 17);
            this.SaveToFileCheckBox.TabIndex = 1;
            this.SaveToFileCheckBox.Text = "Save To File";
            this.SaveToFileCheckBox.UseVisualStyleBackColor = true;
            this.SaveToFileCheckBox.CheckedChanged += new System.EventHandler(this.SaveToFileCheckBox_CheckedChanged);
            // 
            // GoButton
            // 
            this.GoButton.Enabled = false;
            this.GoButton.Location = new System.Drawing.Point(183, 89);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(88, 40);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // oneArgumentRadioButton
            // 
            this.oneArgumentRadioButton.AutoSize = true;
            this.oneArgumentRadioButton.Location = new System.Drawing.Point(0, 5);
            this.oneArgumentRadioButton.Name = "oneArgumentRadioButton";
            this.oneArgumentRadioButton.Size = new System.Drawing.Size(93, 17);
            this.oneArgumentRadioButton.TabIndex = 3;
            this.oneArgumentRadioButton.Text = "One Argument";
            this.oneArgumentRadioButton.UseVisualStyleBackColor = true;
            this.oneArgumentRadioButton.CheckedChanged += new System.EventHandler(this.oneArgumentRadioButton_CheckedChanged);
            // 
            // twoArgumentsRadioButton
            // 
            this.twoArgumentsRadioButton.AutoSize = true;
            this.twoArgumentsRadioButton.Location = new System.Drawing.Point(169, 5);
            this.twoArgumentsRadioButton.Name = "twoArgumentsRadioButton";
            this.twoArgumentsRadioButton.Size = new System.Drawing.Size(99, 17);
            this.twoArgumentsRadioButton.TabIndex = 4;
            this.twoArgumentsRadioButton.Text = "Two Arguments";
            this.twoArgumentsRadioButton.UseVisualStyleBackColor = true;
            this.twoArgumentsRadioButton.CheckedChanged += new System.EventHandler(this.twoArgumentsRadioButton_CheckedChanged);
            // 
            // firstArgumentTextBox
            // 
            this.firstArgumentTextBox.Location = new System.Drawing.Point(42, 51);
            this.firstArgumentTextBox.Name = "firstArgumentTextBox";
            this.firstArgumentTextBox.Size = new System.Drawing.Size(41, 20);
            this.firstArgumentTextBox.TabIndex = 5;
            // 
            // secondArgumentTextBox
            // 
            this.secondArgumentTextBox.Location = new System.Drawing.Point(211, 51);
            this.secondArgumentTextBox.Name = "secondArgumentTextBox";
            this.secondArgumentTextBox.Size = new System.Drawing.Size(41, 20);
            this.secondArgumentTextBox.TabIndex = 6;
            // 
            // mathComboBox
            // 
            this.mathComboBox.FormattingEnabled = true;
            this.mathComboBox.Location = new System.Drawing.Point(102, 51);
            this.mathComboBox.Name = "mathComboBox";
            this.mathComboBox.Size = new System.Drawing.Size(87, 21);
            this.mathComboBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oneArgumentRadioButton);
            this.groupBox1.Controls.Add(this.twoArgumentsRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 33);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 241);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mathComboBox);
            this.Controls.Add(this.secondArgumentTextBox);
            this.Controls.Add(this.firstArgumentTextBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.SaveToFileCheckBox);
            this.Controls.Add(this.DialogCheckBox);
            this.Name = "MainWindow";
            this.Text = "Delegate Example";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DialogCheckBox;
        private System.Windows.Forms.CheckBox SaveToFileCheckBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.RadioButton oneArgumentRadioButton;
        private System.Windows.Forms.RadioButton twoArgumentsRadioButton;
        private System.Windows.Forms.TextBox firstArgumentTextBox;
        private System.Windows.Forms.TextBox secondArgumentTextBox;
        private System.Windows.Forms.ComboBox mathComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


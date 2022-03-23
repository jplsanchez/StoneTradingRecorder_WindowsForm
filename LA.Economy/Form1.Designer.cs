namespace LA.Economy
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
            this.Register_Button = new System.Windows.Forms.Button();
            this.Date_TextBox = new System.Windows.Forms.TextBox();
            this.Value_TextBox = new System.Windows.Forms.TextBox();
            this.Value_Label = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.Type_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register_Button
            // 
            this.Register_Button.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register_Button.Location = new System.Drawing.Point(345, 68);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(118, 87);
            this.Register_Button.TabIndex = 0;
            this.Register_Button.Text = "Registrar Compra";
            this.Register_Button.UseVisualStyleBackColor = true;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // Date_TextBox
            // 
            this.Date_TextBox.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date_TextBox.Location = new System.Drawing.Point(12, 158);
            this.Date_TextBox.Name = "Date_TextBox";
            this.Date_TextBox.Size = new System.Drawing.Size(289, 30);
            this.Date_TextBox.TabIndex = 1;
            // 
            // Value_TextBox
            // 
            this.Value_TextBox.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Value_TextBox.Location = new System.Drawing.Point(12, 99);
            this.Value_TextBox.Name = "Value_TextBox";
            this.Value_TextBox.Size = new System.Drawing.Size(289, 30);
            this.Value_TextBox.TabIndex = 2;
            // 
            // Value_Label
            // 
            this.Value_Label.AutoSize = true;
            this.Value_Label.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Value_Label.Location = new System.Drawing.Point(12, 73);
            this.Value_Label.Name = "Value_Label";
            this.Value_Label.Size = new System.Drawing.Size(119, 23);
            this.Value_Label.TabIndex = 3;
            this.Value_Label.Text = "Preço Pago";
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date_Label.Location = new System.Drawing.Point(12, 132);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(54, 23);
            this.Date_Label.TabIndex = 4;
            this.Date_Label.Text = "Data";
            // 
            // Type_ComboBox
            // 
            this.Type_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Type_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Type_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_ComboBox.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Type_ComboBox.FormattingEnabled = true;
            this.Type_ComboBox.Location = new System.Drawing.Point(12, 36);
            this.Type_ComboBox.Name = "Type_ComboBox";
            this.Type_ComboBox.Size = new System.Drawing.Size(289, 31);
            this.Type_ComboBox.TabIndex = 5;
            // 
            // Type_Label
            // 
            this.Type_Label.AutoSize = true;
            this.Type_Label.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Type_Label.Location = new System.Drawing.Point(12, 10);
            this.Type_Label.Name = "Type_Label";
            this.Type_Label.Size = new System.Drawing.Size(142, 23);
            this.Type_Label.TabIndex = 6;
            this.Type_Label.Text = "Tipo de Pedra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 204);
            this.Controls.Add(this.Type_Label);
            this.Controls.Add(this.Type_ComboBox);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Value_Label);
            this.Controls.Add(this.Value_TextBox);
            this.Controls.Add(this.Date_TextBox);
            this.Controls.Add(this.Register_Button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Register_Button;
        private TextBox Date_TextBox;
        private TextBox Value_TextBox;
        private Label Value_Label;
        private Label Date_Label;
        private ComboBox Type_ComboBox;
        private Label Type_Label;
    }
}
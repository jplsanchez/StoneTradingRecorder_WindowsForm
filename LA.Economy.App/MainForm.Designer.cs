using System.Windows.Forms;

namespace LA.Economy.App
{
    partial class MainForm
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
            this.ValueTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.DateTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.resultButton1 = new MaterialSkin.Controls.MaterialButton();
            this.TypeComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.QuantityTextBox = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValueTextBox1
            // 
            this.ValueTextBox1.AnimateReadOnly = false;
            this.ValueTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValueTextBox1.Depth = 0;
            this.ValueTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ValueTextBox1.Hint = "Preço Pago";
            this.ValueTextBox1.LeadingIcon = null;
            this.ValueTextBox1.Location = new System.Drawing.Point(15, 244);
            this.ValueTextBox1.MaxLength = 50;
            this.ValueTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.ValueTextBox1.Multiline = false;
            this.ValueTextBox1.Name = "ValueTextBox1";
            this.ValueTextBox1.Size = new System.Drawing.Size(171, 50);
            this.ValueTextBox1.TabIndex = 0;
            this.ValueTextBox1.Text = "";
            this.ValueTextBox1.TrailingIcon = null;
            // 
            // DateTextBox2
            // 
            this.DateTextBox2.AnimateReadOnly = false;
            this.DateTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTextBox2.Depth = 0;
            this.DateTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateTextBox2.Hint = "Data";
            this.DateTextBox2.LeadingIcon = null;
            this.DateTextBox2.Location = new System.Drawing.Point(15, 162);
            this.DateTextBox2.MaxLength = 50;
            this.DateTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.DateTextBox2.Multiline = false;
            this.DateTextBox2.Name = "DateTextBox2";
            this.DateTextBox2.Size = new System.Drawing.Size(334, 50);
            this.DateTextBox2.TabIndex = 1;
            this.DateTextBox2.Text = "";
            this.DateTextBox2.TrailingIcon = null;
            // 
            // resultButton1
            // 
            this.resultButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resultButton1.Depth = 0;
            this.resultButton1.HighEmphasis = true;
            this.resultButton1.Icon = null;
            this.resultButton1.Location = new System.Drawing.Point(401, 244);
            this.resultButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resultButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultButton1.Name = "resultButton1";
            this.resultButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resultButton1.Size = new System.Drawing.Size(99, 36);
            this.resultButton1.TabIndex = 2;
            this.resultButton1.Text = "Registrar";
            this.resultButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resultButton1.UseAccentColor = false;
            this.resultButton1.UseVisualStyleBackColor = true;
            this.resultButton1.Click += new System.EventHandler(this.resultButton1_Click);
            // 
            // TypeComboBox1
            // 
            this.TypeComboBox1.AutoResize = false;
            this.TypeComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TypeComboBox1.Depth = 0;
            this.TypeComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TypeComboBox1.DropDownHeight = 174;
            this.TypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox1.DropDownWidth = 121;
            this.TypeComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TypeComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TypeComboBox1.FormattingEnabled = true;
            this.TypeComboBox1.Hint = "Tipo de Pedra";
            this.TypeComboBox1.IntegralHeight = false;
            this.TypeComboBox1.ItemHeight = 43;
            this.TypeComboBox1.Location = new System.Drawing.Point(15, 79);
            this.TypeComboBox1.MaxDropDownItems = 4;
            this.TypeComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.TypeComboBox1.Name = "TypeComboBox1";
            this.TypeComboBox1.Size = new System.Drawing.Size(334, 49);
            this.TypeComboBox1.StartIndex = 0;
            this.TypeComboBox1.TabIndex = 3;
            this.TypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LA.Economy.App.Properties.Resources._1___DSC;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(439, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Dark Mode";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 0);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 8;
            this.materialDrawer1.UseColors = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(382, 79);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(141, 133);
            this.materialCard1.TabIndex = 9;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.AnimateReadOnly = false;
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityTextBox.Depth = 0;
            this.QuantityTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuantityTextBox.Hint = "Quantidade";
            this.QuantityTextBox.LeadingIcon = null;
            this.QuantityTextBox.Location = new System.Drawing.Point(192, 244);
            this.QuantityTextBox.MaxLength = 50;
            this.QuantityTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.QuantityTextBox.Multiline = false;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(157, 50);
            this.QuantityTextBox.TabIndex = 10;
            this.QuantityTextBox.Text = "";
            this.QuantityTextBox.TrailingIcon = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 317);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.resultButton1);
            this.Controls.Add(this.ValueTextBox1);
            this.Controls.Add(this.TypeComboBox1);
            this.Controls.Add(this.DateTextBox2);
            this.Controls.Add(this.materialDrawer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Venda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox ValueTextBox1;
        private MaterialSkin.Controls.MaterialTextBox DateTextBox2;
        private MaterialSkin.Controls.MaterialButton resultButton1;
        private MaterialSkin.Controls.MaterialComboBox TypeComboBox1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox QuantityTextBox;
    }
}

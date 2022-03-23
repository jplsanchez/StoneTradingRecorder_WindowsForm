using LA.Economy.App.Helpers;
using LA.Economy.Domain.Interfaces.Helpers;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LA.Economy.App
{
    public partial class MainForm : MaterialForm
    {
        private readonly IDataRecorder _recorder;

        private readonly object[] _stoneOptionsList = new object[] {
            "Guardian T3  (Azul)",
            "Destruction T3 (Vermelha)"};

        private readonly MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private readonly Layout _layout;

        public MainForm(IDataRecorder recorder)
        {
            InitializeComponent();

            _recorder = recorder;
            _layout = new(
                this,
                new List<CheckBox>() { checkBox1 }
                );

            _layout.FormSetup();

            this.TypeComboBox1.Items.AddRange(this._stoneOptionsList);
            this.DateTextBox2.Text = DateTime.Now.ToString("g");
        }

        private async void resultButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await _recorder.RecordSellAsync(TypeComboBox1.Text, ValueTextBox1.Text, QuantityTextBox.Text, DateTextBox2.Text);

                string message =
                    $"\nID: {data.Id} \n\n" +
                    $"Tipo: {data.Type} \n\n" +
                    $"Valor: {data.Price} G \n\n" +
                    $"Quantidade: {data.Quantity} \n\n" +
                    $"Data: {data.Date}";

                MaterialMessageBox.Show(message, "Registrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IMPLEMENTAR ACHAR AUTOMATICO NA LISTA: Regex 0->0
            //ERRO: A lista de propriedades vem vazia
            //var index = TypeComboBox1.SelectedIndex;
            //var teste = typeof(global::LA.Economy.App.Properties.Resources).GetProperties();
            //foreach (PropertyInfo property in typeof(global::LA.Economy.App.Properties.Resources).GetProperties())
            //{
            //    if (property.Name.StartsWith($"_{index}"))
            //    {
            //        object? obj = property.GetValue(null);
            //        if (obj != null)
            //        {
            //            pictureBox1.Image = (System.Drawing.Bitmap)obj;
            //            pictureBox1.Visible = true;
            //            return;
            //        }
            //    }
            //}

            if (TypeComboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = global::LA.Economy.App.Properties.Resources._1___DSC;
                pictureBox1.Visible = true;
                return;
            }

            if (TypeComboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = global::LA.Economy.App.Properties.Resources._0___GSC;
                pictureBox1.Visible = true;
                return;
            }

            pictureBox1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _layout.SetDarkTheme();
                return;
            }
            _layout.SetWhiteTheme();
        }

        private void OpenForm<T>() where T : MaterialForm, new()
        {
            var dataForm = new T();
            this.Hide();
            dataForm.ShowDialog();
        }
    }
}
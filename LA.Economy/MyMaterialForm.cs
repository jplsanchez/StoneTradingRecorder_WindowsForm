using LA.Economy.Interfaces.Helpers;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LA.Economy
{
    public partial class MyMaterialForm : MaterialForm
    {
        private readonly IDataRecorder _recorder;

        private readonly object[] _stoneOptionsList = new object[] {
            "Guardian T3  (Azul)",
            "Destruction T3 (Vermelha)"};

        private readonly MaterialSkinManager TManager = MaterialSkinManager.Instance;

        public MyMaterialForm(IDataRecorder recorder)
        {
            _recorder = recorder;

            InitializeComponent();
            FormSetup();

            this.TypeComboBox1.Items.AddRange(this._stoneOptionsList);
            this.DateTextBox2.Text = DateTime.Now.ToString("g");
        }

        private void FormSetup()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            TManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private async void resultButton1_Click(object sender, EventArgs e)
        {
            try
            {
                await _recorder.RecordSellAsync(TypeComboBox1.Text, ValueTextBox1.Text, DateTextBox2.Text);
                MaterialMessageBox.Show("Registrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void TypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeComboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = global::LA.Economy.Properties.Resources.DSC;
                pictureBox1.Visible = true;
                return;
            }

            if (TypeComboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = global::LA.Economy.Properties.Resources.GSC;
                pictureBox1.Visible = true;
                return;
            }

            pictureBox1.Visible = false;
        }
    }
}
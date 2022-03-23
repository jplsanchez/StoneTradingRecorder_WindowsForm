using LA.Economy.Interfaces.Helpers;

namespace LA.Economy
{
    public partial class Form1 : Form
    {
        private readonly IDataRecorder _recorder;

        private readonly object[] _stoneOptionsList = new object[] {
            "Guardian T3  (Azul)",
            "Destruction T3 (Vermelha)"};

        public Form1(IDataRecorder recorder)
        {
            _recorder = recorder;
            InitializeComponent();
            this.Type_ComboBox.Items.AddRange(this._stoneOptionsList);
            this.Date_TextBox.Text = DateTime.Now.ToString("g");
        }

        private async void Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                await _recorder.RecordSellAsync(Type_ComboBox.Text, Value_TextBox.Text, Date_TextBox.Text);
                MessageBox.Show("Registrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
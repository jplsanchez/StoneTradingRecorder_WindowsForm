using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LA.Economy.App.Helpers
{
    public class Layout
    {
        private readonly MaterialForm _form;
        private readonly List<CheckBox> _listOfCheckBoxes;

        private readonly MaterialSkinManager TManager = MaterialSkinManager.Instance;

        public Layout(MaterialForm form, List<CheckBox> listOfCheckBoxes)
        {
            _form = form;
            _listOfCheckBoxes = listOfCheckBoxes;
        }

        public void FormSetup()
        {
            TManager.AddFormToManage(_form);
            SetDarkTheme();
        }

        public void SetWhiteTheme()
        {
            TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            TManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);

            foreach (var component in _listOfCheckBoxes)
            {
                component.BackColor = System.Drawing.Color.Transparent;
                component.ForeColor = System.Drawing.Color.White;
            }
        }

        public void SetDarkTheme()
        {
            TManager.Theme = MaterialSkinManager.Themes.DARK;
            TManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);

            foreach (var component in _listOfCheckBoxes)
            {
                component.BackColor = System.Drawing.Color.Transparent;
                component.ForeColor = System.Drawing.Color.White;
            }
        }
    }
}
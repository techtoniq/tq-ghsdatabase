using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Techtoniq.GHSDatabase;

namespace WindowsFormsFrameworkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnButtonSearchClick(object sender, EventArgs e)
        {
            IGHSDatabase db = new GHSDatabase();
            IHazard hazard = db.Get(uxTextCodeValue.Text, uxTextCultureValue.Text);

            if (null == hazard)
            {
                uxPictureHazardPictogram.Image = null;
                uxLabelHazardPhrase.Text = string.Empty;
            }
            else
            {
                MemoryStream ms = new MemoryStream(hazard.PictogramImage);
                uxPictureHazardPictogram.Image = Image.FromStream(ms);
                uxPictureHazardPictogram.SizeMode = PictureBoxSizeMode.StretchImage;

                uxLabelHazardPhrase.Text = hazard.Phrase;
            }
        }
    }
}

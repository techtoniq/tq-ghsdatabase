using System;
using System.Drawing;
using System.IO;
using System.Text;
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
            IGhsDatabase db = new GhsDatabase();
            IHazard hazard = db.Get(uxTextCodeValue.Text, uxTextCultureValue.Text);

            if (null == hazard)
            {
                uxPictureHazardPictogram.Image = null;
                uxTextClassValue.Text = string.Empty;
                uxTextCategoryValue.Text = string.Empty;
                uxTextSignalWordValue.Text = string.Empty;
                uxTextPhraseValue.Text = string.Empty;
                uxTextPCodesValue.Text = string.Empty;
            }
            else
            {
                MemoryStream ms = new MemoryStream(hazard.PictogramImage);
                uxPictureHazardPictogram.Image = Image.FromStream(ms);
                uxPictureHazardPictogram.SizeMode = PictureBoxSizeMode.StretchImage;

                uxTextClassValue.Text = hazard.Class;
                uxTextCategoryValue.Text = string.Join(", ", hazard.Categories);
                uxTextSignalWordValue.Text = hazard.SignalWord;
                uxTextPhraseValue.Text = hazard.Phrase;

                StringBuilder pcodeStatement = new StringBuilder();
                foreach(var pcode in hazard.PCodes)
                {
                    pcodeStatement.AppendLine($"{pcode.Code}\t{pcode.Phrase}");
                }
                uxTextPCodesValue.Text = pcodeStatement.ToString();
            }
        }
    }
}

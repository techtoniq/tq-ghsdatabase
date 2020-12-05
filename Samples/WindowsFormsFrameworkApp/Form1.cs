using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
            IList<IHazard> hazards = db.Get(uxTextCodeValue.Text, uxTextCultureValue.Text);

            if (hazards.Any())
            {
                // Show the first match as an example.

                if(hazards[0].PictogramImages.Any())
                {
                    MemoryStream ms = new MemoryStream(hazards[0].PictogramImages[0]);  // use the first image
                    uxPictureHazardPictogram.Image = Image.FromStream(ms);
                    uxPictureHazardPictogram.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    uxPictureHazardPictogram.Image = null;
                }

                uxTextClassValue.Text = hazards[0].Class;
                uxTextCategoryValue.Text = string.Join(", ", hazards[0].Categories);
                uxTextSignalWordValue.Text = hazards[0].SignalWord;
                uxTextPhraseValue.Text = hazards[0].Phrase;

                StringBuilder pcodeStatement = new StringBuilder();
                foreach (var pcode in hazards[0].PCodes)
                {
                    pcodeStatement.AppendLine($"{pcode.Code}\t{pcode.Phrase}");
                }
                uxTextPCodesValue.Text = pcodeStatement.ToString();
            }
            else
            {
                uxPictureHazardPictogram.Image = null;
                uxTextClassValue.Text = string.Empty;
                uxTextCategoryValue.Text = string.Empty;
                uxTextSignalWordValue.Text = string.Empty;
                uxTextPhraseValue.Text = string.Empty;
                uxTextPCodesValue.Text = string.Empty;
            }
        }
    }
}

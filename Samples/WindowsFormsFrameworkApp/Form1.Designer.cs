namespace WindowsFormsFrameworkApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxLabelCodeCaption = new System.Windows.Forms.Label();
            this.uxTextCodeValue = new System.Windows.Forms.TextBox();
            this.uxButtonSearch = new System.Windows.Forms.Button();
            this.uxLabelHazardPhrase = new System.Windows.Forms.Label();
            this.uxPictureHazardPictogram = new System.Windows.Forms.PictureBox();
            this.uxLabelCultureCaption = new System.Windows.Forms.Label();
            this.uxTextCultureValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureHazardPictogram)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLabelCodeCaption
            // 
            this.uxLabelCodeCaption.AutoSize = true;
            this.uxLabelCodeCaption.Location = new System.Drawing.Point(88, 95);
            this.uxLabelCodeCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelCodeCaption.Name = "uxLabelCodeCaption";
            this.uxLabelCodeCaption.Size = new System.Drawing.Size(47, 20);
            this.uxLabelCodeCaption.TabIndex = 0;
            this.uxLabelCodeCaption.Text = "Code";
            // 
            // uxTextCodeValue
            // 
            this.uxTextCodeValue.Location = new System.Drawing.Point(146, 91);
            this.uxTextCodeValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTextCodeValue.Name = "uxTextCodeValue";
            this.uxTextCodeValue.Size = new System.Drawing.Size(88, 26);
            this.uxTextCodeValue.TabIndex = 0;
            this.uxTextCodeValue.Text = "H200";
            // 
            // uxButtonSearch
            // 
            this.uxButtonSearch.Location = new System.Drawing.Point(244, 88);
            this.uxButtonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonSearch.Name = "uxButtonSearch";
            this.uxButtonSearch.Size = new System.Drawing.Size(112, 35);
            this.uxButtonSearch.TabIndex = 2;
            this.uxButtonSearch.Text = "&Search";
            this.uxButtonSearch.UseVisualStyleBackColor = true;
            this.uxButtonSearch.Click += new System.EventHandler(this.OnButtonSearchClick);
            // 
            // uxLabelHazardPhrase
            // 
            this.uxLabelHazardPhrase.AutoSize = true;
            this.uxLabelHazardPhrase.Location = new System.Drawing.Point(304, 308);
            this.uxLabelHazardPhrase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelHazardPhrase.Name = "uxLabelHazardPhrase";
            this.uxLabelHazardPhrase.Size = new System.Drawing.Size(51, 20);
            this.uxLabelHazardPhrase.TabIndex = 3;
            this.uxLabelHazardPhrase.Text = "label2";
            // 
            // uxPictureHazardPictogram
            // 
            this.uxPictureHazardPictogram.Location = new System.Drawing.Point(93, 229);
            this.uxPictureHazardPictogram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxPictureHazardPictogram.Name = "uxPictureHazardPictogram";
            this.uxPictureHazardPictogram.Size = new System.Drawing.Size(180, 185);
            this.uxPictureHazardPictogram.TabIndex = 4;
            this.uxPictureHazardPictogram.TabStop = false;
            // 
            // uxLabelCultureCaption
            // 
            this.uxLabelCultureCaption.AutoSize = true;
            this.uxLabelCultureCaption.Location = new System.Drawing.Point(76, 135);
            this.uxLabelCultureCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelCultureCaption.Name = "uxLabelCultureCaption";
            this.uxLabelCultureCaption.Size = new System.Drawing.Size(60, 20);
            this.uxLabelCultureCaption.TabIndex = 0;
            this.uxLabelCultureCaption.Text = "Culture";
            // 
            // uxTextCultureValue
            // 
            this.uxTextCultureValue.Location = new System.Drawing.Point(146, 131);
            this.uxTextCultureValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTextCultureValue.Name = "uxTextCultureValue";
            this.uxTextCultureValue.Size = new System.Drawing.Size(88, 26);
            this.uxTextCultureValue.TabIndex = 1;
            this.uxTextCultureValue.Text = "en";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.uxPictureHazardPictogram);
            this.Controls.Add(this.uxLabelHazardPhrase);
            this.Controls.Add(this.uxButtonSearch);
            this.Controls.Add(this.uxTextCultureValue);
            this.Controls.Add(this.uxLabelCultureCaption);
            this.Controls.Add(this.uxTextCodeValue);
            this.Controls.Add(this.uxLabelCodeCaption);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureHazardPictogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelCodeCaption;
        private System.Windows.Forms.TextBox uxTextCodeValue;
        private System.Windows.Forms.Button uxButtonSearch;
        private System.Windows.Forms.Label uxLabelHazardPhrase;
        private System.Windows.Forms.PictureBox uxPictureHazardPictogram;
        private System.Windows.Forms.Label uxLabelCultureCaption;
        private System.Windows.Forms.TextBox uxTextCultureValue;
    }
}


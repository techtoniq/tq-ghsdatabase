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
            this.uxPictureHazardPictogram = new System.Windows.Forms.PictureBox();
            this.uxLabelCultureCaption = new System.Windows.Forms.Label();
            this.uxTextCultureValue = new System.Windows.Forms.TextBox();
            this.uxLabelClassCaption = new System.Windows.Forms.Label();
            this.uxTextClassValue = new System.Windows.Forms.TextBox();
            this.uxTextCategoryValue = new System.Windows.Forms.TextBox();
            this.uxLabelCategoryCaption = new System.Windows.Forms.Label();
            this.uxLabelSignalWordCaption = new System.Windows.Forms.Label();
            this.uxTextSignalWordValue = new System.Windows.Forms.TextBox();
            this.uxLabelPhraseCaption = new System.Windows.Forms.Label();
            this.uxTextPhraseValue = new System.Windows.Forms.TextBox();
            this.uxLabelPCodesCaption = new System.Windows.Forms.Label();
            this.uxTextPCodesValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureHazardPictogram)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLabelCodeCaption
            // 
            this.uxLabelCodeCaption.AutoSize = true;
            this.uxLabelCodeCaption.Location = new System.Drawing.Point(28, 29);
            this.uxLabelCodeCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelCodeCaption.Name = "uxLabelCodeCaption";
            this.uxLabelCodeCaption.Size = new System.Drawing.Size(47, 20);
            this.uxLabelCodeCaption.TabIndex = 0;
            this.uxLabelCodeCaption.Text = "Code";
            // 
            // uxTextCodeValue
            // 
            this.uxTextCodeValue.Location = new System.Drawing.Point(86, 25);
            this.uxTextCodeValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTextCodeValue.Name = "uxTextCodeValue";
            this.uxTextCodeValue.Size = new System.Drawing.Size(88, 26);
            this.uxTextCodeValue.TabIndex = 0;
            this.uxTextCodeValue.Text = "H200";
            // 
            // uxButtonSearch
            // 
            this.uxButtonSearch.Location = new System.Drawing.Point(184, 22);
            this.uxButtonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonSearch.Name = "uxButtonSearch";
            this.uxButtonSearch.Size = new System.Drawing.Size(112, 35);
            this.uxButtonSearch.TabIndex = 2;
            this.uxButtonSearch.Text = "&Search";
            this.uxButtonSearch.UseVisualStyleBackColor = true;
            this.uxButtonSearch.Click += new System.EventHandler(this.OnButtonSearchClick);
            // 
            // uxPictureHazardPictogram
            // 
            this.uxPictureHazardPictogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxPictureHazardPictogram.Location = new System.Drawing.Point(33, 163);
            this.uxPictureHazardPictogram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxPictureHazardPictogram.Name = "uxPictureHazardPictogram";
            this.uxPictureHazardPictogram.Size = new System.Drawing.Size(180, 185);
            this.uxPictureHazardPictogram.TabIndex = 4;
            this.uxPictureHazardPictogram.TabStop = false;
            // 
            // uxLabelCultureCaption
            // 
            this.uxLabelCultureCaption.AutoSize = true;
            this.uxLabelCultureCaption.Location = new System.Drawing.Point(16, 69);
            this.uxLabelCultureCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelCultureCaption.Name = "uxLabelCultureCaption";
            this.uxLabelCultureCaption.Size = new System.Drawing.Size(60, 20);
            this.uxLabelCultureCaption.TabIndex = 0;
            this.uxLabelCultureCaption.Text = "Culture";
            // 
            // uxTextCultureValue
            // 
            this.uxTextCultureValue.Location = new System.Drawing.Point(86, 65);
            this.uxTextCultureValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTextCultureValue.Name = "uxTextCultureValue";
            this.uxTextCultureValue.Size = new System.Drawing.Size(88, 26);
            this.uxTextCultureValue.TabIndex = 1;
            this.uxTextCultureValue.Text = "en";
            // 
            // uxLabelClassCaption
            // 
            this.uxLabelClassCaption.AutoSize = true;
            this.uxLabelClassCaption.Location = new System.Drawing.Point(294, 163);
            this.uxLabelClassCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelClassCaption.Name = "uxLabelClassCaption";
            this.uxLabelClassCaption.Size = new System.Drawing.Size(48, 20);
            this.uxLabelClassCaption.TabIndex = 3;
            this.uxLabelClassCaption.Text = "Class";
            // 
            // uxTextClassValue
            // 
            this.uxTextClassValue.Location = new System.Drawing.Point(349, 160);
            this.uxTextClassValue.Name = "uxTextClassValue";
            this.uxTextClassValue.ReadOnly = true;
            this.uxTextClassValue.Size = new System.Drawing.Size(295, 26);
            this.uxTextClassValue.TabIndex = 5;
            // 
            // uxTextCategoryValue
            // 
            this.uxTextCategoryValue.Location = new System.Drawing.Point(349, 192);
            this.uxTextCategoryValue.Name = "uxTextCategoryValue";
            this.uxTextCategoryValue.ReadOnly = true;
            this.uxTextCategoryValue.Size = new System.Drawing.Size(295, 26);
            this.uxTextCategoryValue.TabIndex = 5;
            // 
            // uxLabelCategoryCaption
            // 
            this.uxLabelCategoryCaption.AutoSize = true;
            this.uxLabelCategoryCaption.Location = new System.Drawing.Point(269, 195);
            this.uxLabelCategoryCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelCategoryCaption.Name = "uxLabelCategoryCaption";
            this.uxLabelCategoryCaption.Size = new System.Drawing.Size(73, 20);
            this.uxLabelCategoryCaption.TabIndex = 3;
            this.uxLabelCategoryCaption.Text = "Category";
            // 
            // uxLabelSignalWordCaption
            // 
            this.uxLabelSignalWordCaption.AutoSize = true;
            this.uxLabelSignalWordCaption.Location = new System.Drawing.Point(247, 227);
            this.uxLabelSignalWordCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelSignalWordCaption.Name = "uxLabelSignalWordCaption";
            this.uxLabelSignalWordCaption.Size = new System.Drawing.Size(95, 20);
            this.uxLabelSignalWordCaption.TabIndex = 3;
            this.uxLabelSignalWordCaption.Text = "Signal Word";
            // 
            // uxTextSignalWordValue
            // 
            this.uxTextSignalWordValue.Location = new System.Drawing.Point(349, 224);
            this.uxTextSignalWordValue.Name = "uxTextSignalWordValue";
            this.uxTextSignalWordValue.ReadOnly = true;
            this.uxTextSignalWordValue.Size = new System.Drawing.Size(295, 26);
            this.uxTextSignalWordValue.TabIndex = 5;
            // 
            // uxLabelPhraseCaption
            // 
            this.uxLabelPhraseCaption.AutoSize = true;
            this.uxLabelPhraseCaption.Location = new System.Drawing.Point(283, 259);
            this.uxLabelPhraseCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelPhraseCaption.Name = "uxLabelPhraseCaption";
            this.uxLabelPhraseCaption.Size = new System.Drawing.Size(59, 20);
            this.uxLabelPhraseCaption.TabIndex = 3;
            this.uxLabelPhraseCaption.Text = "Phrase";
            // 
            // uxTextPhraseValue
            // 
            this.uxTextPhraseValue.Location = new System.Drawing.Point(349, 256);
            this.uxTextPhraseValue.Name = "uxTextPhraseValue";
            this.uxTextPhraseValue.ReadOnly = true;
            this.uxTextPhraseValue.Size = new System.Drawing.Size(688, 26);
            this.uxTextPhraseValue.TabIndex = 5;
            // 
            // uxLabelPCodesCaption
            // 
            this.uxLabelPCodesCaption.AutoSize = true;
            this.uxLabelPCodesCaption.Location = new System.Drawing.Point(272, 291);
            this.uxLabelPCodesCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelPCodesCaption.Name = "uxLabelPCodesCaption";
            this.uxLabelPCodesCaption.Size = new System.Drawing.Size(70, 20);
            this.uxLabelPCodesCaption.TabIndex = 3;
            this.uxLabelPCodesCaption.Text = "P-Codes";
            // 
            // uxTextPCodesValue
            // 
            this.uxTextPCodesValue.Location = new System.Drawing.Point(349, 288);
            this.uxTextPCodesValue.Multiline = true;
            this.uxTextPCodesValue.Name = "uxTextPCodesValue";
            this.uxTextPCodesValue.ReadOnly = true;
            this.uxTextPCodesValue.Size = new System.Drawing.Size(688, 249);
            this.uxTextPCodesValue.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 556);
            this.Controls.Add(this.uxTextPCodesValue);
            this.Controls.Add(this.uxTextPhraseValue);
            this.Controls.Add(this.uxTextSignalWordValue);
            this.Controls.Add(this.uxLabelPCodesCaption);
            this.Controls.Add(this.uxTextCategoryValue);
            this.Controls.Add(this.uxLabelPhraseCaption);
            this.Controls.Add(this.uxTextClassValue);
            this.Controls.Add(this.uxLabelSignalWordCaption);
            this.Controls.Add(this.uxPictureHazardPictogram);
            this.Controls.Add(this.uxLabelCategoryCaption);
            this.Controls.Add(this.uxLabelClassCaption);
            this.Controls.Add(this.uxButtonSearch);
            this.Controls.Add(this.uxTextCultureValue);
            this.Controls.Add(this.uxLabelCultureCaption);
            this.Controls.Add(this.uxTextCodeValue);
            this.Controls.Add(this.uxLabelCodeCaption);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Techtoniq.GHSDatabase Nuget Package Example";
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureHazardPictogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelCodeCaption;
        private System.Windows.Forms.TextBox uxTextCodeValue;
        private System.Windows.Forms.Button uxButtonSearch;
        private System.Windows.Forms.PictureBox uxPictureHazardPictogram;
        private System.Windows.Forms.Label uxLabelCultureCaption;
        private System.Windows.Forms.TextBox uxTextCultureValue;
        private System.Windows.Forms.Label uxLabelClassCaption;
        private System.Windows.Forms.TextBox uxTextClassValue;
        private System.Windows.Forms.TextBox uxTextCategoryValue;
        private System.Windows.Forms.Label uxLabelCategoryCaption;
        private System.Windows.Forms.Label uxLabelSignalWordCaption;
        private System.Windows.Forms.TextBox uxTextSignalWordValue;
        private System.Windows.Forms.Label uxLabelPhraseCaption;
        private System.Windows.Forms.TextBox uxTextPhraseValue;
        private System.Windows.Forms.Label uxLabelPCodesCaption;
        private System.Windows.Forms.TextBox uxTextPCodesValue;
    }
}


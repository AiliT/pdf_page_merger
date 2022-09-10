namespace WinFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.originPathTextBox = new System.Windows.Forms.TextBox();
            this.resultPathTextBox = new System.Windows.Forms.TextBox();
            this.textToSearchTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kansio, mistä PDF tiedostot luetaan: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valmistetun tiedoston nimi (ilman .pdf): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Etsittävä teksti: ";
            // 
            // originPathTextBox
            // 
            this.originPathTextBox.Location = new System.Drawing.Point(291, 36);
            this.originPathTextBox.Name = "originPathTextBox";
            this.originPathTextBox.Size = new System.Drawing.Size(444, 27);
            this.originPathTextBox.TabIndex = 3;
            // 
            // resultPathTextBox
            // 
            this.resultPathTextBox.Location = new System.Drawing.Point(291, 93);
            this.resultPathTextBox.Name = "resultPathTextBox";
            this.resultPathTextBox.Size = new System.Drawing.Size(444, 27);
            this.resultPathTextBox.TabIndex = 4;
            // 
            // textToSearchTextBox
            // 
            this.textToSearchTextBox.Location = new System.Drawing.Point(291, 148);
            this.textToSearchTextBox.Name = "textToSearchTextBox";
            this.textToSearchTextBox.Size = new System.Drawing.Size(444, 27);
            this.textToSearchTextBox.TabIndex = 5;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(350, 193);
            this.resultLabel.MinimumSize = new System.Drawing.Size(100, 30);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 30);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(350, 240);
            this.startButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 29);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Aloita";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 273);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.textToSearchTextBox);
            this.Controls.Add(this.resultPathTextBox);
            this.Controls.Add(this.originPathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "PDF sivujen yhdistäjä";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox originPathTextBox;
        private TextBox resultPathTextBox;
        private TextBox textToSearchTextBox;
        private Label resultLabel;
        private Button startButton;
    }
}
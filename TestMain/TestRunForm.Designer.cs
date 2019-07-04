namespace TestMain
{
    partial class TestRunForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextLabel = new System.Windows.Forms.Label();
            this.AnswerBox = new System.Windows.Forms.GroupBox();
            this.VariantsCheckBox = new System.Windows.Forms.CheckedListBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.ImageViewer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.AnswerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextLabel);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 123);
            this.panel1.TabIndex = 0;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.Location = new System.Drawing.Point(4, 16);
            this.TextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextLabel.MaximumSize = new System.Drawing.Size(1040, 111);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(164, 30);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "QuestionText";
            // 
            // AnswerBox
            // 
            this.AnswerBox.Controls.Add(this.VariantsCheckBox);
            this.AnswerBox.Location = new System.Drawing.Point(16, 769);
            this.AnswerBox.Margin = new System.Windows.Forms.Padding(4);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Padding = new System.Windows.Forms.Padding(4);
            this.AnswerBox.Size = new System.Drawing.Size(1446, 218);
            this.AnswerBox.TabIndex = 1;
            this.AnswerBox.TabStop = false;
            this.AnswerBox.Text = "Варианты ответа";
            // 
            // VariantsCheckBox
            // 
            this.VariantsCheckBox.CheckOnClick = true;
            this.VariantsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VariantsCheckBox.FormattingEnabled = true;
            this.VariantsCheckBox.Location = new System.Drawing.Point(8, 23);
            this.VariantsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.VariantsCheckBox.Name = "VariantsCheckBox";
            this.VariantsCheckBox.Size = new System.Drawing.Size(1430, 190);
            this.VariantsCheckBox.TabIndex = 0;
            this.VariantsCheckBox.SelectedIndexChanged += new System.EventHandler(this.VariantsCheckBox_SelectedIndexChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(1346, 1009);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(116, 28);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ImageViewer
            // 
            this.ImageViewer.Location = new System.Drawing.Point(16, 145);
            this.ImageViewer.Margin = new System.Windows.Forms.Padding(4);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(1446, 617);
            this.ImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageViewer.TabIndex = 3;
            this.ImageViewer.TabStop = false;
            // 
            // TestRunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1475, 1043);
            this.Controls.Add(this.ImageViewer);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestRunForm";
            this.Text = "TestRunForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AnswerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.GroupBox AnswerBox;
        private System.Windows.Forms.CheckedListBox VariantsCheckBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.PictureBox ImageViewer;
    }
}
namespace TestMain
{
    partial class SettingsForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassEvalComboBox = new System.Windows.Forms.ComboBox();
            this.Score1Label = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.FailTextBox = new System.Windows.Forms.TextBox();
            this.Score2Label = new System.Windows.Forms.Label();
            this.FailEvalComboBox = new System.Windows.Forms.ComboBox();
            this.FailLabel = new System.Windows.Forms.Label();
            this.PassCommentTextBox = new System.Windows.Forms.TextBox();
            this.CommentLabel_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FailCommentTextBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(82, 447);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(301, 447);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(12, 9);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(188, 13);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Критерий успешного прохождения :";
            // 
            // PassEvalComboBox
            // 
            this.PassEvalComboBox.FormattingEnabled = true;
            this.PassEvalComboBox.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<="});
            this.PassEvalComboBox.Location = new System.Drawing.Point(15, 25);
            this.PassEvalComboBox.Name = "PassEvalComboBox";
            this.PassEvalComboBox.Size = new System.Drawing.Size(50, 21);
            this.PassEvalComboBox.TabIndex = 3;
            // 
            // Score1Label
            // 
            this.Score1Label.AutoSize = true;
            this.Score1Label.Location = new System.Drawing.Point(138, 28);
            this.Score1Label.Name = "Score1Label";
            this.Score1Label.Size = new System.Drawing.Size(55, 13);
            this.Score1Label.TabIndex = 4;
            this.Score1Label.Text = "балла(ов)";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(71, 25);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(61, 20);
            this.PassTextBox.TabIndex = 5;
            // 
            // FailTextBox
            // 
            this.FailTextBox.Location = new System.Drawing.Point(71, 192);
            this.FailTextBox.Name = "FailTextBox";
            this.FailTextBox.Size = new System.Drawing.Size(61, 20);
            this.FailTextBox.TabIndex = 9;
            // 
            // Score2Label
            // 
            this.Score2Label.AutoSize = true;
            this.Score2Label.Location = new System.Drawing.Point(138, 195);
            this.Score2Label.Name = "Score2Label";
            this.Score2Label.Size = new System.Drawing.Size(55, 13);
            this.Score2Label.TabIndex = 8;
            this.Score2Label.Text = "балла(ов)";
            // 
            // FailEvalComboBox
            // 
            this.FailEvalComboBox.FormattingEnabled = true;
            this.FailEvalComboBox.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<="});
            this.FailEvalComboBox.Location = new System.Drawing.Point(15, 192);
            this.FailEvalComboBox.Name = "FailEvalComboBox";
            this.FailEvalComboBox.Size = new System.Drawing.Size(50, 21);
            this.FailEvalComboBox.TabIndex = 7;
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.Location = new System.Drawing.Point(12, 176);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(109, 13);
            this.FailLabel.TabIndex = 6;
            this.FailLabel.Text = "Критерий  провала :";
            // 
            // PassCommentTextBox
            // 
            this.PassCommentTextBox.Location = new System.Drawing.Point(15, 65);
            this.PassCommentTextBox.Multiline = true;
            this.PassCommentTextBox.Name = "PassCommentTextBox";
            this.PassCommentTextBox.Size = new System.Drawing.Size(438, 95);
            this.PassCommentTextBox.TabIndex = 10;
            // 
            // CommentLabel_1
            // 
            this.CommentLabel_1.AutoSize = true;
            this.CommentLabel_1.Location = new System.Drawing.Point(12, 49);
            this.CommentLabel_1.Name = "CommentLabel_1";
            this.CommentLabel_1.Size = new System.Drawing.Size(80, 13);
            this.CommentLabel_1.TabIndex = 11;
            this.CommentLabel_1.Text = "Комментарий:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Комментарий:";
            // 
            // FailCommentTextBox
            // 
            this.FailCommentTextBox.Location = new System.Drawing.Point(15, 232);
            this.FailCommentTextBox.Multiline = true;
            this.FailCommentTextBox.Name = "FailCommentTextBox";
            this.FailCommentTextBox.Size = new System.Drawing.Size(438, 95);
            this.FailCommentTextBox.TabIndex = 12;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(12, 339);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(139, 13);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Времени на вопрос (сек) :";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(15, 364);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimeTextBox.TabIndex = 15;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 499);
            this.ControlBox = false;
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FailCommentTextBox);
            this.Controls.Add(this.CommentLabel_1);
            this.Controls.Add(this.PassCommentTextBox);
            this.Controls.Add(this.FailTextBox);
            this.Controls.Add(this.Score2Label);
            this.Controls.Add(this.FailEvalComboBox);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.Score1Label);
            this.Controls.Add(this.PassEvalComboBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Параметры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.ComboBox PassEvalComboBox;
        private System.Windows.Forms.Label Score1Label;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox FailTextBox;
        private System.Windows.Forms.Label Score2Label;
        private System.Windows.Forms.ComboBox FailEvalComboBox;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.TextBox PassCommentTextBox;
        private System.Windows.Forms.Label CommentLabel_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FailCommentTextBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox TimeTextBox;
    }
}
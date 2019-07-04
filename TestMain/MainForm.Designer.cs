namespace TestMain
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTestToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadTestToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTestToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunTestToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionsList = new System.Windows.Forms.ListBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.AnswersBox = new System.Windows.Forms.GroupBox();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.VariantsCheckBox = new System.Windows.Forms.CheckedListBox();
            this.DeleteAnswer = new System.Windows.Forms.Button();
            this.AddAnswer = new System.Windows.Forms.Button();
            this.NewQuestionButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImageViewer = new System.Windows.Forms.PictureBox();
            this.AdditionalGroupBox = new System.Windows.Forms.GroupBox();
            this.AddImageButton = new System.Windows.Forms.Button();
            this.DeleteImageButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AboutToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.AnswersBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).BeginInit();
            this.AdditionalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестToolStripMenuItem,
            this.TestingMenuItem,
            this.SettingsMenuItem,
            this.AboutToolItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(873, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTestToolItem,
            this.LoadTestToolItem,
            this.SaveTestToolItem});
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // NewTestToolItem
            // 
            this.NewTestToolItem.Name = "NewTestToolItem";
            this.NewTestToolItem.Size = new System.Drawing.Size(132, 22);
            this.NewTestToolItem.Text = "Новый";
            this.NewTestToolItem.Click += new System.EventHandler(this.NewTestToolItem_Click);
            // 
            // LoadTestToolItem
            // 
            this.LoadTestToolItem.Name = "LoadTestToolItem";
            this.LoadTestToolItem.Size = new System.Drawing.Size(132, 22);
            this.LoadTestToolItem.Text = "Загрузить";
            this.LoadTestToolItem.Click += new System.EventHandler(this.LoadTestToolItem_Click);
            // 
            // SaveTestToolItem
            // 
            this.SaveTestToolItem.Enabled = false;
            this.SaveTestToolItem.Name = "SaveTestToolItem";
            this.SaveTestToolItem.Size = new System.Drawing.Size(132, 22);
            this.SaveTestToolItem.Text = "Сохранить";
            this.SaveTestToolItem.Click += new System.EventHandler(this.SaveTestToolItem_Click);
            // 
            // TestingMenuItem
            // 
            this.TestingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunTestToolItem});
            this.TestingMenuItem.Enabled = false;
            this.TestingMenuItem.Name = "TestingMenuItem";
            this.TestingMenuItem.Size = new System.Drawing.Size(96, 20);
            this.TestingMenuItem.Text = "Тестирование";
            // 
            // RunTestToolItem
            // 
            this.RunTestToolItem.Name = "RunTestToolItem";
            this.RunTestToolItem.Size = new System.Drawing.Size(113, 22);
            this.RunTestToolItem.Text = "Начать";
            this.RunTestToolItem.Click += new System.EventHandler(this.RunTestToolItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsMenuItem.Text = "Настройки";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // QuestionsList
            // 
            this.QuestionsList.FormattingEnabled = true;
            this.QuestionsList.Location = new System.Drawing.Point(1, 27);
            this.QuestionsList.Name = "QuestionsList";
            this.QuestionsList.Size = new System.Drawing.Size(118, 654);
            this.QuestionsList.TabIndex = 1;
            this.QuestionsList.SelectedIndexChanged += new System.EventHandler(this.QuestionsList_SelectedIndexChanged);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(125, 27);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(88, 13);
            this.TextLabel.TabIndex = 2;
            this.TextLabel.Text = "Текст вопроса :";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Enabled = false;
            this.QuestionTextBox.Location = new System.Drawing.Point(128, 43);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(733, 79);
            this.QuestionTextBox.TabIndex = 3;
            // 
            // AnswersBox
            // 
            this.AnswersBox.Controls.Add(this.ScoreTextBox);
            this.AnswersBox.Controls.Add(this.ScoreLabel);
            this.AnswersBox.Controls.Add(this.VariantsCheckBox);
            this.AnswersBox.Controls.Add(this.DeleteAnswer);
            this.AnswersBox.Controls.Add(this.AddAnswer);
            this.AnswersBox.Location = new System.Drawing.Point(128, 467);
            this.AnswersBox.Name = "AnswersBox";
            this.AnswersBox.Size = new System.Drawing.Size(301, 171);
            this.AnswersBox.TabIndex = 4;
            this.AnswersBox.TabStop = false;
            this.AnswersBox.Text = "Ответ";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Enabled = false;
            this.ScoreTextBox.Location = new System.Drawing.Point(190, 35);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(86, 20);
            this.ScoreTextBox.TabIndex = 8;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(187, 19);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(51, 13);
            this.ScoreLabel.TabIndex = 7;
            this.ScoreLabel.Text = "Оценка :";
            // 
            // VariantsCheckBox
            // 
            this.VariantsCheckBox.CheckOnClick = true;
            this.VariantsCheckBox.FormattingEnabled = true;
            this.VariantsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.VariantsCheckBox.Name = "VariantsCheckBox";
            this.VariantsCheckBox.Size = new System.Drawing.Size(156, 94);
            this.VariantsCheckBox.TabIndex = 3;
            // 
            // DeleteAnswer
            // 
            this.DeleteAnswer.Enabled = false;
            this.DeleteAnswer.Location = new System.Drawing.Point(87, 142);
            this.DeleteAnswer.Name = "DeleteAnswer";
            this.DeleteAnswer.Size = new System.Drawing.Size(75, 23);
            this.DeleteAnswer.TabIndex = 1;
            this.DeleteAnswer.Text = "Удалить";
            this.DeleteAnswer.UseVisualStyleBackColor = true;
            this.DeleteAnswer.Click += new System.EventHandler(this.DeleteAnswer_Click);
            // 
            // AddAnswer
            // 
            this.AddAnswer.Enabled = false;
            this.AddAnswer.Location = new System.Drawing.Point(6, 142);
            this.AddAnswer.Name = "AddAnswer";
            this.AddAnswer.Size = new System.Drawing.Size(75, 23);
            this.AddAnswer.TabIndex = 0;
            this.AddAnswer.Text = "Добавить";
            this.AddAnswer.UseVisualStyleBackColor = true;
            this.AddAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
            // 
            // NewQuestionButton
            // 
            this.NewQuestionButton.Enabled = false;
            this.NewQuestionButton.Location = new System.Drawing.Point(648, 654);
            this.NewQuestionButton.Name = "NewQuestionButton";
            this.NewQuestionButton.Size = new System.Drawing.Size(98, 23);
            this.NewQuestionButton.TabIndex = 5;
            this.NewQuestionButton.Text = "Новый вопрос";
            this.NewQuestionButton.UseVisualStyleBackColor = true;
            this.NewQuestionButton.Click += new System.EventHandler(this.NewQuestionButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(535, 654);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить вопрос";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Enabled = false;
            this.SettingsButton.Location = new System.Drawing.Point(443, 654);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(86, 23);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.Text = "Параметры";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImageViewer);
            this.groupBox1.Location = new System.Drawing.Point(128, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 333);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изображение";
            // 
            // ImageViewer
            // 
            this.ImageViewer.Location = new System.Drawing.Point(6, 19);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(721, 308);
            this.ImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageViewer.TabIndex = 1;
            this.ImageViewer.TabStop = false;
            // 
            // AdditionalGroupBox
            // 
            this.AdditionalGroupBox.Controls.Add(this.AddImageButton);
            this.AdditionalGroupBox.Controls.Add(this.DeleteImageButton);
            this.AdditionalGroupBox.Location = new System.Drawing.Point(447, 467);
            this.AdditionalGroupBox.Name = "AdditionalGroupBox";
            this.AdditionalGroupBox.Size = new System.Drawing.Size(408, 171);
            this.AdditionalGroupBox.TabIndex = 9;
            this.AdditionalGroupBox.TabStop = false;
            this.AdditionalGroupBox.Text = "Дополнительно";
            // 
            // AddImageButton
            // 
            this.AddImageButton.Enabled = false;
            this.AddImageButton.Location = new System.Drawing.Point(6, 19);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(136, 23);
            this.AddImageButton.TabIndex = 1;
            this.AddImageButton.Text = "Добавить изображение";
            this.AddImageButton.UseVisualStyleBackColor = true;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // DeleteImageButton
            // 
            this.DeleteImageButton.Enabled = false;
            this.DeleteImageButton.Location = new System.Drawing.Point(6, 47);
            this.DeleteImageButton.Name = "DeleteImageButton";
            this.DeleteImageButton.Size = new System.Drawing.Size(136, 23);
            this.DeleteImageButton.TabIndex = 0;
            this.DeleteImageButton.Text = "Удалить изображение";
            this.DeleteImageButton.UseVisualStyleBackColor = true;
            this.DeleteImageButton.Click += new System.EventHandler(this.DeleteImageButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(752, 654);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(103, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Удалить вопрос";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AboutToolItem
            // 
            this.AboutToolItem.Name = "AboutToolItem";
            this.AboutToolItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolItem.Text = "О программе";
            this.AboutToolItem.Click += new System.EventHandler(this.AboutToolItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 689);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AdditionalGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewQuestionButton);
            this.Controls.Add(this.AnswersBox);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.QuestionsList);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Тестирование";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.AnswersBox.ResumeLayout(false);
            this.AnswersBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).EndInit();
            this.AdditionalGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewTestToolItem;
        private System.Windows.Forms.ToolStripMenuItem LoadTestToolItem;
        private System.Windows.Forms.ToolStripMenuItem SaveTestToolItem;
        private System.Windows.Forms.ToolStripMenuItem TestingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunTestToolItem;
        private System.Windows.Forms.ListBox QuestionsList;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.GroupBox AnswersBox;
        private System.Windows.Forms.Button DeleteAnswer;
        private System.Windows.Forms.Button AddAnswer;
        private System.Windows.Forms.Button NewQuestionButton;
        private System.Windows.Forms.CheckedListBox VariantsCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ImageViewer;
        private System.Windows.Forms.GroupBox AdditionalGroupBox;
        private System.Windows.Forms.Button DeleteImageButton;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolItem;
    }
}


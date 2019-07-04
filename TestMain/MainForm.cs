using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;
using BLL;
using TestHandler;
//third part
using Essy.Tools.InputBox;
using IniParser;
using IniParser.Model;


namespace TestMain
{
    public partial class MainForm : Form
    {
        //shared
        public static string LogPath;
        //vars
        bool IsCurrentQuestionSaved;
        int CurrentQuestionIndex;
        Test CurrentTest;
        //BLL.Question NewQuestion = new BLL.Question("Текст вопроса", BLL.AnswerType.One, List<BLL.Answer>());

        public MainForm()
        {
            InitializeComponent();
            var iniProvider = new FileIniDataParser();
            if (!File.Exists("settings.ini"))
            {
                //var iniProvider = new FileIniDataParser();
                IniData data = new IniData(); //= iniProvider.ReadFile("settings.ini");
                data["main"]["logPath"] = LogPath = Application.StartupPath;
                iniProvider.WriteFile("settings.ini", data);
            }
            else
            {
                try
                {
                    IniData data = iniProvider.ReadFile("settings.ini");
                    LogPath = data["main"]["logPath"];
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка конфигурирования. Сброс настроек.\n" + ex.Message);
                    LogPath = Application.StartupPath;
                }
            }
            IsCurrentQuestionSaved = true;
            CurrentQuestionIndex = -1;
            CurrentTest = null;
            QuestionTextBox.TextChanged += TextBoxes_TextChanged;
            ScoreTextBox.TextChanged += TextBoxes_TextChanged;
        }

        //создаем новый тест
        private void NewTestToolItem_Click(object sender, EventArgs e)
        {
            if (CurrentTest != null)
            {
                QuestionsList.Items.Clear();
                CurrentQuestionIndex = -1;
            }
            string testName = InputBox.ShowInputBox("Название теста");
            if ((testName == null) || (testName.Length == 0))
            {
                //MessageBox.Show("Введите название теста");
                return;
            }
            CurrentTest = new BLL.Test(testName);
            
            CurrentTest.Questions.Add(new Question("Текст вопроса"));
            QuestionsList.Items.Add("Вопрос 1");
            Text = "Тестирование : " + testName;
            TestingMenuItem.Enabled = true;
            SaveTestToolItem.Enabled = true;

        }

        //изменение в полях
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            IsCurrentQuestionSaved = false;
            CurrentQuestionIndex = QuestionsList.SelectedIndex;
        }

        //сменили вопрос
        private void QuestionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuestionsList.SelectedIndex == -1)
            {
                QuestionTextBox.Text = "";
                QuestionTextBox.Enabled = false;
                AddAnswer.Enabled = false;
                DeleteAnswer.Enabled = false;
                //
                //MultiRadioButton.Checked = false;
                //MultiRadioButton.Enabled = false;
                //OnlyOneRadioButton.Checked = false;
                //OnlyOneRadioButton.Enabled = false;
                //
                ScoreTextBox.Text = "";
                ScoreTextBox.Enabled = false;
                SettingsButton.Enabled = false;
                SaveButton.Enabled = false;
                NewQuestionButton.Enabled = false;

                AddImageButton.Enabled = false;
                DeleteImageButton.Enabled = false;
                DeleteButton.Enabled = false;
                return;
            }

            if (QuestionsList.SelectedIndex != CurrentQuestionIndex)
            {
                if (!IsCurrentQuestionSaved)
                    if (MessageBox.Show("Текущий вопрос изменен. Отменить изменения и продолжить ?", "Подтверждение", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    {
                        QuestionsList.SelectedIndex = CurrentQuestionIndex;
                        return;
                    }
            }
            //return;

            //CurrentQuestionIndex = QuestionsList.SelectedIndex;

            //установка текста вопроса
            QuestionTextBox.Enabled = true;
            QuestionTextBox.Text = CurrentTest.Questions[QuestionsList.SelectedIndex].Text;
            //варианты ответов
            VariantsCheckBox.Items.Clear();
            foreach (var i in CurrentTest.Questions[QuestionsList.SelectedIndex].Answers)
            {
                VariantsCheckBox.Items.Add(i.Key, i.Value);
            }
            //
            AddAnswer.Enabled = true;
            DeleteAnswer.Enabled = true;
            ScoreTextBox.Enabled = true;
            ScoreTextBox.Text = CurrentTest.Questions[QuestionsList.SelectedIndex].Score.ToString();

            SettingsButton.Enabled = true;
            SaveButton.Enabled = true;
            NewQuestionButton.Enabled = true;

            AddImageButton.Enabled = true;
            DeleteImageButton.Enabled = true;
            DeleteButton.Enabled = true;
            ImageViewer.Image = CurrentTest.Questions[QuestionsList.SelectedIndex].Image;

            IsCurrentQuestionSaved = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            var currentQuestion = CurrentTest.Questions[QuestionsList.SelectedIndex];
            //копия текущего вопроса
            BLL.Question tmpQuestion = new Question(currentQuestion.Text);
            tmpQuestion.Text = QuestionTextBox.Text;
            //if (OnlyOneRadioButton.Checked)
            //    tmpQuestion.Type = BLL.AnswerType.One;
            //if (MultiRadioButton.Checked)
            //    tmpQuestion.Type = BLL.AnswerType.Multi;
            if (!double.TryParse(ScoreTextBox.Text, out double score))
            {
                MessageBox.Show("Оценка должна быть числом.");
                ScoreTextBox.Text = "";
                return;
            }
            //варианты ответов
            if (VariantsCheckBox.Items.Count == 0)
            {
                MessageBox.Show("Необходимо минимум 1 вариант ответа.");
                return;
            }
            //задаем ответы вопросу
            for (var i = 0; i < VariantsCheckBox.Items.Count; i++)
            {
                tmpQuestion.Answers.Add(VariantsCheckBox.Items[i].ToString(), VariantsCheckBox.GetItemChecked(i));
            }
            tmpQuestion.Image = ImageViewer.Image;
            tmpQuestion.Score = score;

            CurrentTest.Questions[QuestionsList.SelectedIndex] = tmpQuestion;
            IsCurrentQuestionSaved = true;
        }

        private void AddAnswer_Click(object sender, EventArgs e)
        {
            string varText = InputBox.ShowInputBox("Вариант ответа");
            if ((varText == null) || (varText.Length == 0))
            {
                MessageBox.Show("Введите вариант ответа");
                return;
            }
            if (VariantsCheckBox.Items.Contains(varText))
            {
                MessageBox.Show("Такой вариант уже существует.");
                return;
            }
            VariantsCheckBox.Items.Add(varText);
        }

        private void NewQuestionButton_Click(object sender, EventArgs e)
        {
            if (!IsCurrentQuestionSaved)
            {
                MessageBox.Show("Текущий вопрос изменен. Сохраните чтобы продолжить.");
                return;
            }
            CurrentTest.Questions.Add(new BLL.Question("Текст вопроса"));
            QuestionsList.Items.Add("Вопрос " + (CurrentTest.Questions.Count).ToString());
        }

        private void SaveTestToolItem_Click(object sender, EventArgs e)
        {
            //сначала надо провести валидацию теста
            if ((CurrentTest.FailEvaluation == null) ||
                (CurrentTest.PassEvaluation == null) ||
                (CurrentTest.FailMessage == null) ||
                (CurrentTest.PassMessage == null))
            {
                MessageBox.Show("Не заданы параметры теста.");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Выберете файл для сохранения.");
                return;
            }
            if ((sfd.FileName == null) || (sfd.FileName.Length == 0))
            {
                MessageBox.Show("Выберете файл для сохранения.");
                return;
            }
            try
            {
                FileProvider.Save(sfd.FileName, CurrentTest);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения теста." + ex.Message);
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            //перед открытием формы, возможно стоит загружать в нее
            //уже имеющиеся параметры
            Dictionary<string, string> values = new Dictionary<string, string>();
            values["PassEval"] = CurrentTest.PassEvaluation;
            values["FailEval"] = CurrentTest.FailEvaluation;
            values["PassScore"] = CurrentTest.PassScore.ToString();
            values["FailScore"] = CurrentTest.FailScore.ToString();
            values["PassMsg"] = CurrentTest.PassMessage;
            values["FailMsg"] = CurrentTest.FailMessage;
            values["QuestionTime"] = CurrentTest.QuestionTime.ToString();
            SettingsForm sf = new SettingsForm(values);
            sf.ShowDialog(this);
            if (!sf.IsCanceled)
            {
                CurrentTest.FailEvaluation = sf.FailEvaluation;
                CurrentTest.PassEvaluation = sf.PassEvaluation;
                CurrentTest.FailScore = sf.FailScore;
                CurrentTest.PassScore = sf.PassScore;
                CurrentTest.FailMessage = sf.FailMessage;
                CurrentTest.PassMessage = sf.PassMessage;
                CurrentTest.QuestionTime = sf.QuestionTime;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (QuestionsList.SelectedIndex == -1)
                return;
            if (QuestionsList.Items.Count < 2)
            {
                MessageBox.Show("В тесте должен быть минимум 1 вопрос.");
                return;
            }
            
            CurrentTest.Questions.RemoveAt(QuestionsList.SelectedIndex);
            QuestionsList.Items.Clear();
            for (var i = 0; i < CurrentTest.Questions.Count; i++)
            {
                QuestionsList.Items.Add("Вопрос " + (i + 1).ToString());
            }
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Выберете файл изображения.");
                return;
            }
            if ((ofd.FileName == null) || (ofd.FileName.Length == 0))
            {
                MessageBox.Show("Выберете файл изображения.");
                return;
            }

            Image openedImage = null;
            try
            {
                openedImage = Image.FromFile(ofd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть изображение." + ex.Message);
                return;
            }

            ImageViewer.Image = openedImage;
            IsCurrentQuestionSaved = false;
        }

        private void DeleteImageButton_Click(object sender, EventArgs e)
        {
            ImageViewer.Image = null;
            IsCurrentQuestionSaved = false;
        }

        private void LoadTestToolItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Выберете файл теста.");
                return;
            }
            if ((ofd.FileName == null) || (ofd.FileName.Length == 0))
            {
                MessageBox.Show("Выберете файл теста.");
                return;
            }

            Test openedTest = null;
            try
            {
                openedTest = FileProvider.Load(ofd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить тест." + ex.Message);
                return;
            }


            if (CurrentTest != null)
            {
                QuestionsList.Items.Clear();
                QuestionsList.SelectedIndex = -1;
            }
            CurrentTest = openedTest;
            for (var i = 0; i < CurrentTest.Questions.Count; i++)
            {
                QuestionsList.Items.Add("Вопрос " + (i + 1).ToString());
            }

            Text = "Тестирование : " + CurrentTest.Name;

            SaveTestToolItem.Enabled = true;
            TestingMenuItem.Enabled = true;
        }

        private void DeleteAnswer_Click(object sender, EventArgs e)
        {
            if (VariantsCheckBox.SelectedIndex == -1)
                return;
            VariantsCheckBox.Items.RemoveAt(VariantsCheckBox.SelectedIndex);
            IsCurrentQuestionSaved = false;
        }

        private void RunTestToolItem_Click(object sender, EventArgs e)
        {
            string user = InputBox.ShowInputBox("ФИО тестируемого");
            if ((user == null) || (user.Length == 0))
            {
                MessageBox.Show("Необходимо ввести информацию о тестируемом.");
                return;
            }
            TestRunner runner = new TestRunner(CurrentTest, user);
            TestRunForm trf = new TestRunForm(runner);
            Hide();
            trf.ShowDialog(this);
            Show();
            trf.Dispose();
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            string logPath = InputBox.ShowInputBox("Папка с журналами", LogPath, false);
            if ((logPath == null) || (logPath.Length == 0))
                return;
            if (!Directory.Exists(logPath))
            {
                MessageBox.Show("Директория должна существовать. Принято значение по умолчанию.");
                LogPath = Application.StartupPath;
            }
            else
            {
                var iniProvider = new FileIniDataParser();
                IniData data = new IniData();
                data["main"]["logPath"] = logPath;
                iniProvider.WriteFile("settings.ini", data, Encoding.UTF8);
                LogPath = logPath;
            }
            //LogPath = logPath;
        }

        private void AboutToolItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog(this);
        }
    }
}

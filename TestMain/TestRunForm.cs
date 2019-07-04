using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using BLL;
using TestHandler;

namespace TestMain
{
    public partial class TestRunForm : Form
    {
        private TestRunner TestRunner;
        private Question CurrentQuestion;
        //Время текущего вопроса
        private Stopwatch CurQuestionTime;
        private Timer CurQuestionTimer;
        private Dictionary<string, bool> CurrentAnswer;

        public TestRunForm(TestRunner runner)
        {
            InitializeComponent();
            CurrentAnswer = new Dictionary<string, bool>();
            TestRunner = runner;
            //начинаем тестирование
            TestRunner.Start();
            CurrentQuestion = runner.GetQuestion();
            //формируем представление вопроса
            FormatForm();
            CurQuestionTimer = new Timer();
            CurQuestionTimer.Interval = (int)(TestRunner.QuestionTime * 1000); //customize
            CurQuestionTimer.Tick += Timer_OnTick;
            CurQuestionTimer.Start();
        }

        //таймер
        private void Timer_OnTick(object sender, EventArgs e)
        {
            NextButton_Click(sender, e);
        }

        private void FormatForm()
        {
            Text = string.Format("Вопрос {0}/{1}", TestRunner.CurrentQuestionNumber, TestRunner.QuestionsCount);
            if (CurrentQuestion.Image != null)
            {
                ImageViewer.Location = new Point(12, 120);
                ImageViewer.Visible = true;
                ImageViewer.Image = CurrentQuestion.Image;
                AnswerBox.Location = new Point(12, 625);
                NextButton.Location = new Point(1010, 820);
                Height = 890;
            }
            else
            {
                ImageViewer.Visible = false;
                AnswerBox.Location = new Point(12, 120);
                NextButton.Location = new Point(1010, 310);
                Height = 380;
            }
            TextLabel.Text = CurrentQuestion.Text;
            VariantsCheckBox.Items.Clear();

            var variants = CurrentQuestion.Answers.Keys.ToList();
            variants.Sort();
            //randomize sequence
            //var variants = CurrentQuestion.Answers.Keys.ToList();
            //Random rnd = new Random();
            //int n = variants.Count;
            //while (n > 1)
            //{
            //    n--;
            //    int k = rnd.Next(n + 1);
            //    string value = variants[k];
            //    variants[k] = variants[n];
            //    variants[n] = value;
            //}
            foreach (var v in variants)
            {
                VariantsCheckBox.Items.Add(v, false);
            }
            //VariantsCheckBox.Items[0] = "\t\ti\t\ti / 15\ny''[x] = -(y[x]) + 2(tan[x / 2])".Replace("\t", "          ");
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            CurQuestionTimer.Stop();
            Dictionary<string, bool> userAnswers = new Dictionary<string, bool>();
            for (var i = 0; i < VariantsCheckBox.Items.Count; i++)
            {
                userAnswers.Add(VariantsCheckBox.Items[i].ToString(), VariantsCheckBox.GetItemChecked(i));
            }
            if (VariantsCheckBox.SelectedIndex == -1)
            {
                for (var i = 0; i < VariantsCheckBox.Items.Count; i++)
                {
                    CurrentAnswer.Add(VariantsCheckBox.Items[i].ToString(), false);
                }
            }
            TestRunner.CheckAnswers(CurrentAnswer);
            CurrentAnswer.Clear();

            var nextQuest = TestRunner.GetQuestion();
            if (nextQuest == null)
            {
                //calc result
                TestRunner.End();
                //выключаем таймер
                CurQuestionTimer.Enabled = false;

                MessageBox.Show(TestRunner.Result(), "Результат тестирования");
                try
                {
                    TestRunner.SaveLog(MainForm.LogPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка записи журнала." + ex.Message);
                }
                Close();
                return;
            }
            CurQuestionTimer.Start();
            CurrentQuestion = nextQuest;//TestRunner.GetQuestion();
            FormatForm();
        }

        private void VariantsCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VariantsCheckBox.SelectedIndex == -1)
                return;
            CurrentAnswer.Add(VariantsCheckBox.Items[VariantsCheckBox.SelectedIndex].ToString(), true);
            for (var i = 0; i < VariantsCheckBox.Items.Count; i++)
            {
                if (i == VariantsCheckBox.SelectedIndex)
                    continue;
                CurrentAnswer.Add(VariantsCheckBox.Items[i].ToString(), false);
            }
            NextButton_Click(null, null);
        }
    }
}

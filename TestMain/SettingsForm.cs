using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMain
{
    public partial class SettingsForm : Form
    {
        //
        public string FailEvaluation;
        public string PassEvaluation;
        public double FailScore;
        public double PassScore;
        public string FailMessage;
        public string PassMessage;
        public double QuestionTime;
        public bool IsCanceled;

        public SettingsForm(Dictionary<string, string> values)
        {
            InitializeComponent();
            for (var i = 0; i < PassEvalComboBox.Items.Count; i++)
            {
                if (values["PassEval"] == PassEvalComboBox.Items[i].ToString())
                    PassEvalComboBox.SelectedIndex = i;
            }
            PassTextBox.Text = values["PassScore"];
            PassCommentTextBox.Text = values["PassMsg"];

            for (var i = 0; i < FailEvalComboBox.Items.Count; i++)
            {
                if (values["FailEval"] == PassEvalComboBox.Items[i].ToString())
                    FailEvalComboBox.SelectedIndex = i;
            }
            FailTextBox.Text = values["FailScore"];
            FailCommentTextBox.Text = values["FailMsg"];

            TimeTextBox.Text = values["QuestionTime"];

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((PassEvalComboBox.SelectedIndex == -1) || (FailEvalComboBox.SelectedIndex == -1))
            {
                MessageBox.Show("Не выбран метод оценивания.");
                return;
            }
            if ((PassTextBox.Text.Length == 0) || (FailTextBox.Text.Length == 0))
            {
                MessageBox.Show("Не указан оценочный балл.");
                return;
            }

            if (!double.TryParse(PassTextBox.Text, out double passScore))
            {
                MessageBox.Show("Балл должен быть числом.");
                return;
            }
            if (!double.TryParse(FailTextBox.Text, out double failScore))
            {
                MessageBox.Show("Балл должен быть числом.");
                return;
            }
            if (!double.TryParse(TimeTextBox.Text, out double time))
            {
                MessageBox.Show("Время отводимое на вопрос должно быть числом.");
                return;
            }

            FailEvaluation = FailEvalComboBox.Items[FailEvalComboBox.SelectedIndex].ToString();
            PassEvaluation = PassEvalComboBox.Items[PassEvalComboBox.SelectedIndex].ToString();
            FailScore = failScore;
            PassScore = passScore;
            FailMessage = FailCommentTextBox.Text;
            PassMessage = PassCommentTextBox.Text;
            QuestionTime = time;
            IsCanceled = false;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            IsCanceled = true;
            Close();
        }
    }
}

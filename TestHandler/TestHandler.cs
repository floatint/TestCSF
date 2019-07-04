using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using BLL;

namespace TestHandler
{
    //Раннер тестов
    //Дает вопросы, сверяет ответы, считает баллы и т.п.
    public class TestRunner
    {
        private Test Test;
        private double CurrentScore; //текущие набранные баллы
        private int CurrentQuestionIdx; //индекс текущего вопроса
        private string User; //кто проходит тест
        private DateTime StartTime;
        public List<string> Log; //Журнал



        private DateTime GetQuestionTime;
        public Stopwatch FinalzieQuestionTime;

        private bool Successs; //успешно выполнено ?
        private bool Fail;

        //Текущий вопрос
        private Question CurrentQuestion;
        //пройденные вопросы
        private List<Question> PreviousQuestions;


        public double QuestionTime
        {
            get { return Test.QuestionTime; }
        }

        public int QuestionsCount
        {
            get
            {
                return Test.Questions.Count;
            }
        }

        public int CurrentQuestionNumber
        {
            get
            {
                return CurrentQuestionIdx;
            }
        }


        public TestRunner(Test test, string user)
        {
            Test = test;
            PreviousQuestions = new List<Question>();
            User = user;
            Log = new List<string>();
            FinalzieQuestionTime = new Stopwatch();

        }

        //начало тестирования
        public void Start()
        {
            CurrentScore = 0;
            CurrentQuestionIdx = 0;
            Log.Add("Тест : " + Test.Name);
            Log.Add("Тестируемый : " + User);
            StartTime = DateTime.Now;
            Log.Add("Начало тестирования : " + StartTime.ToString());
            Log.Add("\n");
            Log.Add("Вопрос:\tВремя выдачи:\tВремя на ответ:\tОтвет:\tБалл:");
            //Log.Add("---------------------------------------");
        }

        //завершение теста
        public void End()
        {

            //подводим итоги
            switch (Test.PassEvaluation)
            {
                case "=":
                    Successs = CurrentScore == Test.PassScore;
                    break;
                case "<":
                    Successs = CurrentScore < Test.PassScore;
                    break;
                case ">":
                    Successs = CurrentScore > Test.PassScore;
                    break;
                case "<=":
                    Successs = CurrentScore <= Test.PassScore;
                    break;
                case ">=":
                    Successs = CurrentScore >= Test.PassScore;
                    break;
            }
            //если не прошли
            if (!Successs)
            {
                switch (Test.FailEvaluation)
                {
                    case "=":
                        Fail = CurrentScore == Test.FailScore;
                        break;
                    case "<":
                        Fail = CurrentScore < Test.FailScore;
                        break;
                    case ">":
                        Fail = CurrentScore > Test.FailScore;
                        break;
                    case "<=":
                        Fail = CurrentScore <= Test.FailScore;
                        break;
                    case ">=":
                        Fail = CurrentScore >= Test.FailScore;
                        break;
                }
            }

            //Log.Add("---------------------------------------");
            //Log.Add("Тестирование окончено.");
            //DateTime endTime = DateTime.Now;
            //Log.Add("Конец тестирования : " + endTime.ToString());
            //Log.Add("Время тестирования : " + (StartTime - endTime).ToString(@"hh\:mm\:ss"));
            //Log.Add("Итоговая оценка : " + CurrentScore.ToString());
            //if (Successs)
            //    Log.Add("Тест пройден. " + Test.PassMessage);
            //else
            //    if (Fail)
            //        Log.Add("Тест не пройден. " + Test.FailMessage);
            //    else
            //        Log.Add("Тест пройден на средний результат.");
        }

        //формирование отчета
        public string Result()
        {
            string result = "";
            if (Successs)
                result += "Тест пройден.";
            else
                result += "Тест не пройден.";
            result += "\nИтоговый балл : " + CurrentScore.ToString();
            return result;
        }

        ////формирование лога
        //public List<string> Log()
        //{
        //    return null;
        //}

        //получение очередного вопроса
        public Question GetQuestion()
        {
            if (CurrentQuestionIdx == QuestionsCount)
                return null;
            CurrentQuestionIdx++;
            Random rnd = new Random();
            int idx = rnd.Next(Test.Questions.Count);

            var isPrev = PreviousQuestions.Find(x => (x == Test.Questions[idx]));
            if (isPrev == null)
            {

                PreviousQuestions.Add(Test.Questions[idx]);
                CurrentQuestion = Test.Questions[idx];
                GetQuestionTime = DateTime.Now;
                FinalzieQuestionTime.Reset();
                FinalzieQuestionTime.Start();
                return Test.Questions[idx];
            }
            else
            {
                while (isPrev != null)
                {
                    idx = rnd.Next(Test.Questions.Count);
                    isPrev = PreviousQuestions.Find(x => (x == Test.Questions[idx]));
                }
            }
            PreviousQuestions.Add(Test.Questions[idx]);
            CurrentQuestion = Test.Questions[idx];
            GetQuestionTime = DateTime.Now;
            FinalzieQuestionTime.Reset();
            FinalzieQuestionTime.Start();
            return Test.Questions[idx];

        }

        public void SaveLog(string path)
        {
            string fullPath = path + "\\" + User + "_" + Test.Name + "_" + StartTime.ToString().Replace(":", ".") + ".txt";
            File.WriteAllLines(fullPath, Log.ToArray());
        }

        //сверяем ответы
        public void CheckAnswers(Dictionary<string, bool> answers)
        {
            FinalzieQuestionTime.Stop();
            bool passed = true;
            string logItem = CurrentQuestionIdx.ToString() + "\t";
            logItem += GetQuestionTime.ToLongTimeString() + "\t";
            logItem += string.Format("{0},{1}", FinalzieQuestionTime.Elapsed.Seconds, FinalzieQuestionTime.Elapsed.Milliseconds) + "\t";

            //Log.Add("Вопрос " + (CurrentQuestionIdx).ToString() + " : " + CurrentQuestion.Text);
            //Log.Add("Время выдачи : " + GetQuestionTime.ToLongTimeString()/*ToString(@"hh\:mm\:ss")*/);
            //string questTime = string.Format("{0},{1} сек.", FinalzieQuestionTime.Elapsed.Seconds, FinalzieQuestionTime.Elapsed.Milliseconds);
            //Log.Add("Время на ответ : " + questTime);
            //string logAnswer = "Ответ : ";
            if (answers.Where(x => x.Value == true).Count() == 0)
                logItem += "н" + "\t";
            foreach (var v in answers)
            {
                if (v.Value == true)
                    logItem += v.Key + "\t";
                //logAnswer += v.Key + ", ";
                if (CurrentQuestion.Answers[v.Key] != v.Value)
                    passed = false;
            }
            //Log.Add(logAnswer);
            if (passed)
            {
                CurrentScore += CurrentQuestion.Score;
                logItem += CurrentQuestion.Score.ToString();
                //Log.Add("Оценка : " + CurrentQuestion.Score);
            }
            else
            {
                logItem += 0.ToString();
                //Log.Add("Оценка : " + "н".ToString());
            }
            Log.Add(logItem);
            //Log.Add("---------------------------------------");

        }

    }
}

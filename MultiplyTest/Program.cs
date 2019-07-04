using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;


namespace MultiplyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test("Умножение");
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                int a = rnd.Next(1000, 9999);
                int b = rnd.Next(1000, 9999);
                int result = a * b;
                string strRes = result.ToString();
                Question quest = new Question(a.ToString() + " x " + b.ToString() + " = ");
                quest.Score = 1;
                quest.Answers.Add(strRes, true);
                for (var j = 1; j <= 5;j++)
                {
                    int fakeAnswer = rnd.Next(1000000, 9999000);
                    string strFakeAnswer = fakeAnswer.ToString();
                    StringBuilder sb = new StringBuilder(strFakeAnswer);
                    sb[0] = strRes[0];
                    if (strFakeAnswer.Length < strRes.Length)
                    {
                        int diffSize = strRes.Length - strFakeAnswer.Length;
                        for (var g = 0; g < diffSize; g++)
                        {
                            sb.Append(rnd.Next(10).ToString());
                            //sb.Insert(sb.Length / 2, rnd.Next(10).ToString());
                        }

                    }
                    sb[sb.Length - 1] = strRes[strRes.Length - 1];
                    quest.Answers.Add(sb.ToString(), false);
                }
                test.Questions.Add(quest);
            }
            test.PassEvaluation = "=";
            test.PassMessage = "";
            test.PassScore = 70;
            test.FailEvaluation = "<";
            test.FailMessage = "";
            test.FailScore = 70;
            test.QuestionTime = 4;
            FileProvider.Save("Multiply.tst", test);


        }
    }
}

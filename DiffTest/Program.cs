using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using BLL;
using DAL;


namespace DiffTest
{
    class Program
    {
        private static void Shuffle<T>(IList<T> list)
        {
            Random random = new Random();
            int n = list.Count;

            for (int i = list.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                T value = list[rnd];
                list[rnd] = list[i];
                list[i] = value;
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Test test = new Test("Уравнения");
            test.PassEvaluation = ">";
            test.PassMessage = "";
            test.PassScore = 0;
            test.FailEvaluation = "<";
            test.FailMessage = "";
            test.FailScore = 0;
            test.QuestionTime = 4;
            string baseGraphicsPath = "Graphics\\Series_";
            string baseDiffsPath = "Diffs\\Series_";
            List<PointF> numberPos = new List<PointF>();
            numberPos.Add(new PointF(150, 135));
            numberPos.Add(new PointF(450, 135));
            numberPos.Add(new PointF(150, 285));
            numberPos.Add(new PointF(450, 285));

            //генерация вопросов
            for (int i = 0; i < 100; i++)
            {
                Question newQuest = new Question("Какое из уравнений изображено на графике ?");
                //картинка вопроса
                // random
                List<string> selectedGraphics = new List<string>();
                Image questImage = new Bitmap(1000, 900);
                Graphics imgGraphics = Graphics.FromImage(questImage);
                int chartSeries = rnd.Next(1, 3);
                int chartIdx = rnd.Next(1, 40);
                string chartPath = baseGraphicsPath + chartSeries.ToString() + "\\";
                //нарисуем график
                Image chartImg = Image.FromFile(chartPath + chartIdx.ToString() + ".jpg");
                imgGraphics.DrawImage(chartImg, 300, 0);
                //questImage.Save("dfasd.jpg");

                //верный ответ
                string trueDiff = baseDiffsPath + chartSeries.ToString() + "\\" + chartIdx.ToString() + ".jpg";
                selectedGraphics.Add(trueDiff);

                //подбираем графики
                for (int j = 0; j < 5; j++)
                {
                    int diffSeries = rnd.Next(1, 3);
                    int diffIdx = rnd.Next(1, 40);
                    chartPath = baseDiffsPath + diffSeries.ToString() + "\\" + diffIdx.ToString() + ".jpg";
                    while (selectedGraphics.Contains(chartPath))
                    {
                        diffSeries = rnd.Next(1, 3);
                        diffIdx = rnd.Next(1, 40);
                        chartPath = baseDiffsPath + diffSeries.ToString() + "\\" + diffIdx.ToString() + ".jpg";
                    }
                    selectedGraphics.Add(chartPath);
                }
                //перемешаем
                Shuffle<string>(selectedGraphics);
                int trueIdx = selectedGraphics.IndexOf(trueDiff);
                //добавили правильный ответ
                newQuest.Answers.Add((trueIdx + 1).ToString(), true);
                //добавим остальные
                for (var o = 0; o < 6; o++)
                {
                    if (o == trueIdx)
                        continue;
                    newQuest.Answers.Add((o + 1).ToString(), false);
                }
                //список графиков получен, загрузим
                List<Image> imgs = new List<Image>();
                foreach (var g in selectedGraphics)
                {
                    Image cImg = Image.FromFile(g);
                    imgs.Add(cImg);
                }
                //List<Graphics> gList = new List<Graphics>();
                //foreach (var g in imgs)
                //{
                //    gList.Add(Graphics.FromImage(g));
                //}
                //for (var t = 1; t <= 4; t++)
                //{
                //    gList[t - 1].DrawString(t.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 150, 50);
                //}

                //hard
                float numberOffsetX = 60;
                imgGraphics.DrawString("1)".ToString(), new Font("Arial", 18), new SolidBrush(Color.Black), numberOffsetX, 300);
                imgGraphics.DrawString("2)".ToString(), new Font("Arial", 18), new SolidBrush(Color.Black), numberOffsetX, 380);
                imgGraphics.DrawString("3)".ToString(), new Font("Arial", 18), new SolidBrush(Color.Black), numberOffsetX, 460);
                imgGraphics.DrawString("4)".ToString(), new Font("Arial", 18), new SolidBrush(Color.Black), numberOffsetX, 540);
                imgGraphics.DrawString("5)".ToString(), new Font("Arial", 18), new SolidBrush(Color.Black), numberOffsetX, 620);
                imgGraphics.DrawString("6)".ToString(), new Font("Arial", 18), new SolidBrush(Color.Black), numberOffsetX, 700);
                float imgOffsetX = numberOffsetX + 40;
                //отрисовка уравнений
                imgGraphics.DrawImage(imgs[0], imgOffsetX, 280);
                imgGraphics.DrawImage(imgs[1], imgOffsetX, 360);
                imgGraphics.DrawImage(imgs[2], imgOffsetX, 440);
                imgGraphics.DrawImage(imgs[3], imgOffsetX, 520);
                imgGraphics.DrawImage(imgs[4], imgOffsetX, 600);
                imgGraphics.DrawImage(imgs[5], imgOffsetX, 680);
                newQuest.Image = questImage;
                newQuest.Score = 1;
                //questImage.Save("out.jpg");

                //докидываем вопрос
                test.Questions.Add(newQuest);
            }
            FileProvider.Save("Diffs.tst", test);
        }
    }
}

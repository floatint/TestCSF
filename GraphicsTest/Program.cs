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

namespace GraphicsTest
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
            Test test = new Test("Графики");
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
                Question newQuest = new Question("Какой из графиков является решением уравнения ?");
                //картинка вопроса
                // random
                List<string> selectedGraphics = new List<string>();
                Image questImage = new Bitmap(1200, 600);
                Graphics imgGraphics = Graphics.FromImage(questImage);
                int diffSeries = rnd.Next(1,3);
                int diffIdx = rnd.Next(1, 40);
                string diffPath = baseDiffsPath + diffSeries.ToString() + "\\";
                //нарисуем уравнение
                Image diffImg = Image.FromFile(diffPath + diffIdx.ToString() + ".jpg");
                imgGraphics.DrawImage(diffImg, 200, 0);
                //questImage.Save("dfasd.jpg");

                //верный ответ
                string trueGraphics = baseGraphicsPath + diffSeries.ToString() + "\\" + diffIdx.ToString() + ".jpg";
                selectedGraphics.Add(trueGraphics);

                //подбираем графики
                for (int j = 0; j < 5; j++)
                {
                    int graphicsSeries = rnd.Next(1, 3);
                    int graphicsIdx = rnd.Next(1, 40);
                    string graphicsPath = baseGraphicsPath + graphicsSeries.ToString() + "\\" + graphicsIdx.ToString() + ".jpg";
                    while (selectedGraphics.Contains(graphicsPath))
                    {
                        graphicsSeries = rnd.Next(1, 3);
                        graphicsIdx = rnd.Next(1, 40);
                        graphicsPath = baseGraphicsPath + graphicsSeries.ToString() + "\\" + graphicsIdx.ToString() + ".jpg";
                    }
                    selectedGraphics.Add(graphicsPath);
                }
                //перемешаем
                Shuffle<string>(selectedGraphics);
                int trueIdx = selectedGraphics.IndexOf(trueGraphics);
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
                List<Graphics> gList = new List<Graphics>();
                foreach (var g in imgs)
                {
                    gList.Add(Graphics.FromImage(g));
                }
                for (var t = 1; t <= 6; t++)
                {
                    gList[t - 1].DrawString(t.ToString(), new Font("Arial", 14), new SolidBrush(Color.Black), 150, 50);
                }

                //hard
                imgGraphics.DrawImage(imgs[0], 0, 70);
                imgGraphics.DrawImage(imgs[1], 350, 70);
                imgGraphics.DrawImage(imgs[2], 700, 70);
                imgGraphics.DrawImage(imgs[3], 0, 335);
                imgGraphics.DrawImage(imgs[4], 350, 335);
                imgGraphics.DrawImage(imgs[5], 700, 335);
                newQuest.Image = questImage;
                newQuest.Score = 1;
                //questImage.Save("out.jpg");

                //докидываем вопрос
                test.Questions.Add(newQuest);
            }
            FileProvider.Save("Graphics.tst", test);


        }
    }
}

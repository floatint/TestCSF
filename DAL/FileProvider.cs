using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using BLL;

namespace DAL
{

    /*
     * Test File Format
     * 
     * 
     * <Signature> - int = 0xDEAD
     * <Name> - string
     * <FailMessage> - string
     * <PassMessage> - string
     * <FailEvaluation> - string
     * <PassEvaluation> - string
     * <FailScore> - double
     * <PassScore> - double
     * <QuestionTime> - double
     * <Questions count> - int
     * --------
     * <Question_N>
     *  <Text> - string
     *  <Score> - double
     *  <Type> - int
     *  <Image size> - int - 0 = no image
     *  <Image data> - byte[]
     *  <Answers count> - int
     *  ---------------------
     *  <Answer_N>
     *      <Text> - string
     *      <IsSet> - bool
     * 
     * 
     * 
     * 
     */
    public class FileProvider
    {
        static public Test Load(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            
            if (br.ReadInt32() != 0xDEAD)
                throw new Exception("Файл на является тестом.");
            Test tmpTest = new Test(br.ReadString());
            tmpTest.FailMessage = br.ReadString();
            tmpTest.PassMessage = br.ReadString();
            tmpTest.FailEvaluation = br.ReadString();
            tmpTest.PassEvaluation = br.ReadString();
            tmpTest.FailScore = br.ReadDouble();
            tmpTest.PassScore = br.ReadDouble();
            tmpTest.QuestionTime = br.ReadDouble();
            int questionCount = br.ReadInt32();
            for (var i = 0; i < questionCount; i++)
            {
                string questText = br.ReadString();
                double questScore = br.ReadDouble();
                Image img = null;
                int imgSize = br.ReadInt32();
                if (!(imgSize == 0))
                {
                    byte[] imgBytes = br.ReadBytes(imgSize);
                    img = (Bitmap)((new ImageConverter()).ConvertFrom(imgBytes));
                }
                Question newQuestion = new Question(questText);
                newQuestion.Score = questScore;
                newQuestion.Image = img;
                int answersCount = br.ReadInt32();
                for (var j = 0; j < answersCount; j++)
                {
                    string key = br.ReadString();
                    bool val = br.ReadBoolean();
                    newQuestion.Answers.Add(key, val);
                }
                tmpTest.Questions.Add(newQuestion);
            }
            if (br.ReadInt32() != 0xDEAD)
                throw new Exception("Тест имеет неверный формат.");

            br.Close();
            return tmpTest;
        }

        static public void Save(string path, Test test)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

              
            bw.Write(0xDEAD);
            bw.Write(test.Name);
            bw.Write(test.FailMessage);
            bw.Write(test.PassMessage);
            bw.Write(test.FailEvaluation);
            bw.Write(test.PassEvaluation);
            bw.Write(test.FailScore);
            bw.Write(test.PassScore);
            bw.Write(test.QuestionTime);
            bw.Write(test.Questions.Count);
            foreach (var q in test.Questions)
            {
                bw.Write(q.Text);
                bw.Write(q.Score);
                if (q.Image == null)
                    bw.Write(0);
                else
                {
                    Byte[] bytes = (Byte[])new ImageConverter().ConvertTo(q.Image, typeof(Byte[]));
                    bw.Write(bytes.Length);
                    bw.Write(bytes);
                }
                bw.Write(q.Answers.Count);
                foreach (var a in q.Answers)
                {
                    bw.Write(a.Key);
                    bw.Write(a.Value);
                }
            }
            //control
            bw.Write(0xDEAD);
            bw.Close();
        }
    }
}

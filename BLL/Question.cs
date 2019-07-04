using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BLL
{

    public class Question
    {
        //public Dictionary<string, bool> Answers; // словарь с ответами
        public string Text; //текст вопроса
        public double Score; //балл за ответ
        public Dictionary<string, bool> Answers; //список вариантов ответа
        public Image Image; //изображение

        public Question(string text)
        {
            Text = text;
            Answers = new Dictionary<string, bool>();
        }
    }
}

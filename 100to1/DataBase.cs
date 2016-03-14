using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _100to1
{
    class DataBase
    {
        public ArrayList questions = new ArrayList();
        public ArrayList[] answers = new ArrayList[6];
        public ArrayList[] score = new ArrayList[6];
        public void loadBase(string fileName) {
            for (int i = 0; i < 6; i++) {
                answers[i] = new ArrayList();
                score[i] = new ArrayList();
            }
            string file = System.IO.File.ReadAllText(fileName);
            Match match = Regex.Match(file, @"(.*?)\s*\n(.*?)\s(\d+)\r\n(.*?)\s(\d+)\r\n(.*?)\s(\d+)\r\n(.*?)\s(\d+)\r\n(.*?)\s(\d+)\r\n(.*?)\s(\d+)\r\n");
            while (match.Success)
            {
                questions.Add(match.Groups[1].Value);
                for (int i = 0; i < 6; i++) {
                    answers[i].Add(match.Groups[i * 2 + 2].Value);
                    score[i].Add(match.Groups[i * 2 + 3].Value);
                }
                match = match.NextMatch();
            }
            return;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharp_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>() {
                {"1", "один"},
                {"2", "два"},
                {"3", "три"},
                {"4", "четыре"},
                {"5", "пять"},
                {"6", "шесть"},
                {"7", "семь"},
                {"8", "восемь"},
                {"9", "девять"},
                {"10", "десять"}
            };
            List<string> words = new List<string>();
            string filename = $@"C:\Users\leopoldo\source\repos\sharp_task2\sharp_task2\input.txt";
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] line_words = line.Split(' ');
                    for (int i = 0; i < line_words.Length; i++)
                    {
                        words.Add(line_words[i]);
                    }
                }
            }
            for (int i = 0; i < words.Count; i++)
            {
                if (numbers.ContainsKey(words[i]))
                {
                    words[i] = numbers[words[i]];
                }
            }
            string text = "";
            for (int i = 0; i < words.Count; i++)
            {
                text += words[i] + " ";
            }
            textBox1.Text = text;
        }
    }
}

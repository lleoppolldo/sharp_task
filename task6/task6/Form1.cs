using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace spacelib
{
    public partial class Form1 : Form
    {
        public string filename {get;set;}
        RedGiant redgiant = new RedGiant();
        DwarfStar dwarfStar = new DwarfStar();
        SuperGiantStar superGiantStar = new SuperGiantStar();
        List<Star> starlist = new List<Star>();
        List<Star> starscreated = new List<Star>();
        public Form1(string filename_)
        {
            filename = filename_;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label11.Text = "Библиотека " + filename;
            starlist.Add(redgiant);
            starlist.Add(dwarfStar);
            starlist.Add(superGiantStar);
            comboBox1.DataSource = starlist;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "spacelib.RedGiant")
            {
                label7.Text = "Радиус";
            }
            if (comboBox1.Text == "spacelib.DwarfStar")
            {
                label7.Text = "Температура";
            }
            if (comboBox1.Text == "spacelib.SuperGiantStar")
            {
                label7.Text = "Светимость";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "spacelib.RedGiant")
            {
                redgiant.Name = textBox5.Text;
                redgiant.Age = int.Parse(textBox6.Text);
                redgiant.Mass = int.Parse(textBox7.Text);
                redgiant.Radius = int.Parse(textBox8.Text);
                starscreated.Add(redgiant);
                comboBoxClasses.DataSource = null;
                comboBoxClasses.DataSource = starscreated;
            }
            if (comboBox1.Text == "spacelib.DwarfStar")
            {
                dwarfStar.Name = textBox5.Text;
                dwarfStar.Age = int.Parse(textBox6.Text);
                dwarfStar.Mass = int.Parse(textBox7.Text);
                dwarfStar.Temperature = int.Parse(textBox8.Text);
                starscreated.Add(dwarfStar);
                comboBoxClasses.DataSource = null;
                comboBoxClasses.DataSource = starscreated;
            }
            if (comboBox1.Text == "spacelib.SuperGiantStar")
            {
                superGiantStar.Name = textBox5.Text;
                superGiantStar.Age = int.Parse(textBox6.Text);
                superGiantStar.Mass = int.Parse(textBox7.Text);
                superGiantStar.Lumiosity = int.Parse(textBox8.Text);
                starscreated.Add(superGiantStar);
                comboBoxClasses.DataSource = null;
                comboBoxClasses.DataSource = starscreated;
            }
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClasses.Text == "spacelib.RedGiant")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox1.Text = redgiant.Name;
                textBox2.Text = Convert.ToString(redgiant.Age);
                textBox3.Text = Convert.ToString(redgiant.Mass);
                textBox4.Text = Convert.ToString(redgiant.Radius);
                label5.Text = "Радиус";
                button1.Text = "Информация";
                button2.Text = "Взорвать";
            }
            if (comboBoxClasses.Text == "spacelib.DwarfStar")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                label5.Text = "Температура";
                textBox1.Text = dwarfStar.Name;
                textBox2.Text = Convert.ToString(dwarfStar.Age);
                textBox3.Text = Convert.ToString(dwarfStar.Mass);
                textBox4.Text = Convert.ToString(dwarfStar.Temperature);
                button1.Text = "Информация";
                button2.Text = "Взорвать";
            }
            if (comboBoxClasses.Text == "spacelib.SuperGiantStar")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                starscreated.Add(superGiantStar);
                label5.Text = "Светимость";
                textBox1.Text = superGiantStar.Name;
                textBox2.Text = Convert.ToString(superGiantStar.Age);
                textBox3.Text = Convert.ToString(superGiantStar.Mass);
                textBox4.Text = Convert.ToString(superGiantStar.Lumiosity);
                button1.Text = "Информация";
                button2.Text = "Светиться";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxClasses.Text == "spacelib.RedGiant")
            {
                MessageBox.Show(redgiant.GetInfo());
            }
            if (comboBoxClasses.Text == "spacelib.DwarfStar")
            {
                MessageBox.Show(dwarfStar.GetInfo());
            }
            if (comboBoxClasses.Text == "spacelib.SuperGiantStar")
            {
                MessageBox.Show(superGiantStar.GetInfo());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxClasses.Text == "spacelib.RedGiant")
            {
                MessageBox.Show(redgiant.Explode());
            }
            if (comboBoxClasses.Text == "spacelib.DwarfStar")
            {
                MessageBox.Show(dwarfStar.Explode());
            }
            if (comboBoxClasses.Text == "spacelib.SuperGiantStar")
            {
                MessageBox.Show(superGiantStar.GoHypernova());
            }
        }
    }
}

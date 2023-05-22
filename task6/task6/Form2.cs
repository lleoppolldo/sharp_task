using System;
using System.IO;
using System.Windows.Forms;

namespace spacelib
{
    public partial class Form2 : Form
    {
        public string filename;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "dll files (*.dll)|*.dll|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                if(filename == "spacelib")
                {
                    Form1 newForm = new Form1(filename);
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Выбрана некорректная библиотека!");
                }
            }
        }
    }
}

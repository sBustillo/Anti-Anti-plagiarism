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

namespace AntiPlagiarismBypass
{
    public partial class Form1 : Form
    {


        String fileContent = string.Empty;
        String filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();


                    this.textBox1.Text = filePath;

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                   }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if(fileContent == string.Empty)
            {

                MessageBox.Show("FOOL!!! You must select a file");

            }
            else {

                fileContent = fileContent.Replace("A", "А");
                fileContent = fileContent.Replace("e", "е");
                fileContent = fileContent.Replace("i", "і");
                fileContent = fileContent.Replace("o", "о");

                File.WriteAllText(filePath, fileContent);

                MessageBox.Show("Everythign ok");

            }

            



        }
    }
}

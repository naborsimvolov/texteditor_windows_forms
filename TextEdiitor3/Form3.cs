using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form3 : Form
    {
        public Form3(Form f)
        {
            InitializeComponent();
            f.Hide();
            richTextBox1.SelectionColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
       
        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
            

        }
        //private void change()
        //{
        //    if (click == true)
        //    {
        //        FontDialog fd = new FontDialog();

        //        fd.ShowColor = true;//Show color option in font dialog
        //        if (fd.ShowDialog() == DialogResult.OK)
        //        {

        //            //----------------------> How to affect only selected contents
        //            richTextBox1.ForeColor = fd.Color;
        //            richTextBox1.Font = fd.Font;

        //        }
        //    }
        //}

        // дейтсвия при нажатии кнопки "открыть" 
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // окно открытия файла и запись текста из выбранного файла в текстовое поле
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
                try { richTextBox1.LoadFile(OFD.FileName); }
                catch
                {
                    MessageBox.Show("Error");
                }
            richTextBox1.ReadOnly = false;


        }
        //  дейтсвия при нажатии кнопки "сохранить" 
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // окно сохранения файла и запись из текстового поля в выбранный файл
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "txt files (*.rtf;*.txt)|*.rtf;*.txt|All files (*.*)|*.*";
            SFD.ShowDialog();
            if (SFD.FileName == String.Empty) return;
            try
            {
                richTextBox1.SaveFile(SFD.FileName);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        // дейтсвия при нажатии кнопки "выйти" 
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //выход из редактора
            Application.Exit();
        }

        //  дейтсвия при нажатии кнопки "просмотретть файл" 
        private void просмотретьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // окно открытия файла и запись выбранного файла в текстовое поле
           
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
                try { richTextBox1.LoadFile(OFD.FileName); }
                catch
                {
                    MessageBox.Show("Error");
                }
            // запрет на изменение файла
            richTextBox1.ReadOnly = true;


        }




        // дейтсвия при нажатии кнопки "выравнить по левому краю"
        private void left_Click(object sender, EventArgs e)
        {
            // сдвиг текста в текстовом поле richtextbox1 к левому краю
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }


        //  дейтсвия при нажатии кнопки "выравнить по правому краю"
        private void right_Click(object sender, EventArgs e)
        {
            // сдвиг текста в текстовом поле richtextbox1 к правому краю
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        // дейтсвия при нажатии кнопки "выравнить по ширине краю"
        private void center_Click(object sender, EventArgs e)
        {
            // сдвиг текста в текстовом поле richtextbox1 к середине 
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        // действия при нажатии кнопки "Шрифт"
        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }
        // действия при нажатии кнопки "Цвет"
        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}


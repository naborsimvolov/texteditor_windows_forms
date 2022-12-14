using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TextEdiitor2;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1(Form2 f)
        {
            InitializeComponent();
            f.Hide();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
            

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


        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
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

        //  дейтсвия при нажатии кнопки "просмотретть файл" 

        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
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
        // действия при нажати кнопки "выйти"
        private void выйтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}

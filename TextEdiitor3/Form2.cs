using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor;

namespace TextEdiitor2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 whiteForm = new Form1(this);
            whiteForm.Show();
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 blackForm = new Form3(this);
            blackForm.Show();
        }

        
    }
}

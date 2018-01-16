using LogLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String message = "是否选择" + button.Text;

            DialogResult dr;
            dr = MessageBox.Show(message, "Message", MessageBoxButtons.OKCancel);
            
            if(dr == DialogResult.OK)
            {
                Console.WriteLine("OK");
                button.BackColor = Color.Red;
                button.Enabled = false;
                TraceHelper.GetInstance().Info("已选择"+button.Text, "Form Function");
                wordRW.readWord(button.Text);
            }
            else if(dr == DialogResult.Cancel)
            {
                Console.WriteLine("Cancel");
            }

            Console.WriteLine(button.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

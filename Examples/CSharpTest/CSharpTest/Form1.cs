using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTest
{
    public partial class Form1 : Form
    {
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                text: "Hello world",
                caption: "Title!",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information
            );
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(r.Next(1001));
            }
        }
    }
}

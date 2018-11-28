using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
            public Form1()
            {
                InitializeComponent();
            }

            public string[] listData = { "КН-1801", "KН-1701", "КТ-1701", "ПС-1501" };

            private void Form1_Load(object sender, EventArgs e)
            {
                listBox1.DataSource = listData; 

            }

        }

}

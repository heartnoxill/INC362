using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EP14_dot5
{
    public partial class HelloYes : Form
    {
        public HelloYes()
        {
            Debug.WriteLine("This is form1 method");
            InitializeComponent();

            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            if(this.BackColor == Color.Yellow)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.Yellow;
            }

            Debug.WriteLine("Tick!");
        }

        private void HelloYes_Load(object sender, EventArgs e)
        {

        }
    }
}

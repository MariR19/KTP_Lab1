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
        public static void func()
        {
            int i = 1;
            int b = 9 / i;

            for (int j = 0; j<100; j++)
            {
                i++;
                b *= b;
            }

            // Master
        }

    }
}

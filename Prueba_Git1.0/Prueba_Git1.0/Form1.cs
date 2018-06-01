using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Git1._0
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Mi Primer_Repositorioen c#");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p;
            p = 4;
            MessageBox.Show("Mi Primer_Repositorioen c#"+ p);
        }
    }
}

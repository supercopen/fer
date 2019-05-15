using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demoexzamin
{
    public partial class kladovchik : Form
    {
        public kladovchik()
        {
            InitializeComponent();
        }

        private void kladovchik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form lp = new logpas();
            lp.Show();
        }
    }
}

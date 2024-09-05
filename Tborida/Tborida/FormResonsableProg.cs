using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tborida
{
    public partial class FormResonsableProg : Form
    {
        ResponsableProg resPro;
        public FormResonsableProg(ResponsableProg resPro)
        {
            this.resPro = resPro;
            InitializeComponent();
        }

        private void FormResonsableProg_Load(object sender, EventArgs e)
        {

        }

        private void FormResonsableProg_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.resPro.Connection.Close();
        }
    }
}

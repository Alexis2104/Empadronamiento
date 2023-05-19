using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEmpadrona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpadronar_Click(object sender, EventArgs e)
        {
            frmEmpadronar frm = new frmEmpadronar();
            frm.Show();
        }

        private void btnEmpadronados_Click(object sender, EventArgs e)
        {
            frmEmpadronados frm = new frmEmpadronados();
            frm.Show();
        }
    }
}

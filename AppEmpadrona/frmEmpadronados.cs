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
    public partial class frmEmpadronados : Form
    {
        public frmEmpadronados()
        {
            InitializeComponent();
        }

        private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbEmpadronarDataSet);

        }

        private void frmEmpadronados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbEmpadronarDataSet.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.dbEmpadronarDataSet.Personas);

        }
    }
}

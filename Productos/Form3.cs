using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tablas
{
    public partial class entradas : Form
    {
        public entradas()
        {
            InitializeComponent();
        }

        private void entradasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.entradasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'postgresDataSet.entradas' Puede moverla o quitarla según sea necesario.
            this.entradasTableAdapter.Fill(this.postgresDataSet.entradas);

        }
    }
}

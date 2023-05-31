using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMascota
{
    public partial class frmRepuestos : Form

    {

        List<ClaseRepuestos> listaRepuestos = new List<ClaseRepuestos>();




        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClaseRepuestos objRepuesto = new ClaseRepuestos();
            objRepuesto.Nombre = txtNombre.Text;
            objRepuesto.Precio = Convert.ToInt32 (txtPrecio.Text);
            objRepuesto.Codigo = Convert.ToInt32 (txtCodigo.Text);
            objRepuesto.Marca = cmbMarca.Text;

            if (optImportado.Checked == true)
                    {
                    objRepuesto.origen = false;
                }

                if (optNacional.Checked)
                {
                    objRepuesto.origen = true;
                }


            listaRepuestos.Add(objRepuesto);
            MessageBox.Show("Grabacion exitosa");
            MessageBox.Show(objRepuesto.ConsultarRepuestos());
            

            //limpiar controles
            
            MessageBox.Show("Grabado correctamente");

            MessageBox.Show("");
        }
    }
}

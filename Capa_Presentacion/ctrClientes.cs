using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class ctrClientes : UserControl
    {
        public ctrClientes()
        {
            InitializeComponent();
        }

        public string Cedula
        {
            get
            {
                return this.txtCedula.Text.Trim();
            }
            set
            {
                this.txtCedula.Text = value.Trim();
            }
        }

        public string Nombre
        {
            get
            {
                return this.txtNombre.Text.Trim();
            }

            set
            {
                this.txtNombre.Text = value.Trim();
            }
        }

        public string Telefono
        {
            get
            {
                return this.txtTelefono.Text.Trim();
            }

            set
            {
                this.txtTelefono.Text = value.Trim();
            }
        }

        public string Direccion
        {
            get
            {
                return this.txtDireccion.Text.Trim();
            }

            set
            {
                this.txtDireccion.Text = value.Trim();
            }
        }
    }
}

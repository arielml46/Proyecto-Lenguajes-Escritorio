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
    public partial class ctrLogin: UserControl
    {
        public ctrLogin()
        {
            InitializeComponent();
        }

        public string Usuario
        {
            get
            {
                return this.txtUsuario.Text.Trim();
            }
            set
            {
                this.txtUsuario.Text = value.Trim();
            }
        }

        public string Password
        {
            get
            {
                return this.txtPassword.Text.Trim();
            }

            set
            {
                this.txtPassword.Text = value.Trim();
            }
        }

    }
}

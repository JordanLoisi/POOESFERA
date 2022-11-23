using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOEsfera.Entidades;

namespace POOEsfera.windows1
{
    public partial class FrmRadio : Form
    {
        private Esfera esfera;
        public FrmRadio()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (esfera != null)

                RadiotextBox1.Text = esfera.Radio.ToString();
        
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {
                if (esfera==null)
                {
                    esfera = new Esfera();
                }
                esfera.Radio = int.Parse(RadiotextBox1.Text);
                DialogResult = DialogResult.OK;
            }

        }

        private bool validardatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (!int.TryParse(RadiotextBox1.Text,out int radio))
            {
                errorProvider1.SetError(RadiotextBox1 ," el radio tiene que ser entero ");
                valido = false;

            }
            else if (radio<0)
            {
                errorProvider1.SetError(RadiotextBox1, "el radio tiene q ser mayor a 0 ");
                return false;
            }
            return valido;
 
     

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        internal Esfera GetEsfera()
        {
            return esfera;
        }
        internal void SetEsfera (Esfera esfera)
        {
            this.esfera = esfera;
        }

    }
}

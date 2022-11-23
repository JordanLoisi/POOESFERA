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
using POOESFERA.datos;

namespace POOEsfera.windows1
{
    public partial class Frm_Esfera : Form
    {
        bool Haycambios = false;
        public Frm_Esfera()
        {
            InitializeComponent();
        }
        private List<Esfera> lista;
        private RepositorioDeEsfera repo;
        private int cantidad;

        private void Frm_Esfera_Load(object sender, EventArgs e)
        {
            repo = new RepositorioDeEsfera();
            lista = repo.GetLista();
            if (cantidad > 0)
            {
                MostrarLista();
            }
            else
            {
                MessageBox.Show("El Repositorio esta vacío", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            MostrarTotal();
        }

        private void MostrarTotal()
        {
            cantidadlabel.Text = cantidad.ToString();
        }

        private void MostrarLista()
        {
            EsferadataGridView2.Rows.Clear();
            foreach (var Esfera in lista)
            {
                var r = construirFila();
                setearFila(r, Esfera);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            EsferadataGridView2.Rows.Add(r);
        }

        private void setearFila(DataGridViewRow r, Esfera esfera)
        {
            r.Cells[Arecolum.Index].Value = esfera.GetArea().ToString();
            r.Cells[volumecolumna.Index].Value = esfera.GetVolumen().ToString();
            r.Cells[Radiocolum.Index].Value = esfera.Radio;

        }

        private DataGridViewRow construirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(EsferadataGridView2);
            return r;

        }

        private void EsferadataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarLista();
        }

        private void NuevotoolStripButton1_Click(object sender, EventArgs e)
        {
            FrmRadio Frm = new FrmRadio();
            DialogResult dr = Frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("El usuario canceló");
                return;
            }
            var RadioNuevo = Frm.GetEsfera();
            repo.Agregar(RadioNuevo);

            var r = construirFila();
            setearFila(r, RadioNuevo);
            AgregarFila(r);
            MessageBox.Show("radio agregado ");
            cantidad = repo.GetCantidad();
            Haycambios = true;
            MostrarTotal();
        }

        private void salirtoolStripButton1_Click(object sender, EventArgs e)
        {
            if (Haycambios)
            {
                ManejadorDeArchivoSecuenciales.GuardarEnArchivosSecuencial(lista);
            }

            DialogResult dr = MessageBox.Show("¿Desea salir del programa?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void BorrartoolStripButton3_Click(object sender, EventArgs e)
        {
            if (EsferadataGridView2.SelectedRows.Count == 0)
            {
                return;
            }
            var r = EsferadataGridView2.SelectedRows[0];
            Esfera esfera = r.Tag as Esfera;
            DialogResult dr = MessageBox.Show("¿Desea eliminar la fila?", "Confirmar selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                MessageBox.Show("el usuario se arrepintio ");
                return;
            }
            if (repo.Borrar(esfera))
            {
                repo.Borrar(esfera);//El repo borra el Rect
                lista.Remove(esfera);//La saco de la lista de memoria
                EsferadataGridView2.Rows.Remove(r);//La saco de la Grilla
                cantidad= repo.GetCantidad();
                Haycambios = true;
                MostrarTotal();
                MessageBox.Show("Rectangulo eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se pudo dar de baja", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RestaurartoolStripButton5_Click(object sender, EventArgs e)
        {
            lista = repo.GetLista();
            MostrarLista();
            cantidad = repo.GetCantidad();
            MostrarTotal();
        }

        private void EditartoolStripButton2_Click(object sender, EventArgs e)
        {
            if (EsferadataGridView2.SelectedRows.Count==0)
            {
                return;
            }
            var r = EsferadataGridView2.SelectedRows[0];
            Esfera esfera = r.Tag as Esfera;
            FrmRadio frm = new FrmRadio();
            frm.SetEsfera(esfera);
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }
            esfera = frm.GetEsfera();
            setearFila(r, esfera);
            Haycambios = true;
            MessageBox.Show("esfera modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GuardartoolStripButton1_Click(object sender, EventArgs e)
        {
          
                ManejadorDeArchivoSecuenciales.GuardarEnArchivosSecuencial(repo.GetLista());
                MessageBox.Show("Registros Guardados", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }



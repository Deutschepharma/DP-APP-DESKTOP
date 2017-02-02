using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;


namespace DP_APP_DESKTOP.view.Utilitarios
{
    public partial class frmCreaMedico : Form
    {
        public bool respuesta = false;
        public frmCreaMedico()
        {
            InitializeComponent();
        }
        private void CargaAutoCompletar(ComboBox cb, int flag, int cmbFlag)
        {
            Bu_CuadernoOralne box = new Bu_CuadernoOralne();
            DataTable dt = box.CargaCombos(flag, cmbFlag);
            cb.DataSource = dt;
            cb.DisplayMember = "nombre";
            cb.ValueMember = "id";
            cb.AutoCompleteCustomSource = Autocomplete(dt);
            cb.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public static AutoCompleteStringCollection Autocomplete(DataTable data)
        {
            DataTable dt = data;
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nombre"]));
            }
            return coleccion;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Bu_CuadernoOralne bu = new Bu_CuadernoOralne();
            En_CuadernoRegistraMedico m = new En_CuadernoRegistraMedico();
            m.rut = int.Parse(txtRut.Text.Trim());
            m.dv = char.Parse(txtDv.Text.Trim().ToUpper());
            m.nombre = txtNombre.Text.Trim().ToUpper();
            m.paterno = txtPaterno.Text.Trim().ToUpper();
            m.materno = txtMaterno.Text.Trim().ToUpper();
            m.especialidad = cmbEspecialidad.Text;
            m.nacimiento = DateTime.Parse(dtNacimiento.Text);
            m.email = txtEmail.Text.Trim().ToUpper();
            m.fono = txtFono.Text.Trim().ToUpper();

            if (bu.CuadernoRegistraMedico(m)==1)
            {
                MessageBox.Show("Medico registrado con Exito");
                Dispose();
                respuesta = true;
                //limpiar();
            }
            else
            {
                MessageBox.Show("Medico Existe Porfavor Valide Rut!!!");
                txtRut.Focus();
            }
        }

        private void limpiar()
        {
            txtRut.Text = "";
            txtDv.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            cmbEspecialidad.Text = "";


        }

        private void btnNuevaEspecialidad_Click(object sender, EventArgs e)
        {
            Marketing.frmCuadernoEspecialidad f = new Marketing.frmCuadernoEspecialidad();
            f.ShowDialog(this);
            if (f.respuesta)
            {
                CargaAutoCompletar(cmbEspecialidad, 7, 0);
            }
            
        }

        private void frmCreaMedico_Load(object sender, EventArgs e)
        {
            CargaAutoCompletar(cmbEspecialidad, 7, 0);
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}

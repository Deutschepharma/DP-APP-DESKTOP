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
using Utilities;


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
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "Codigo";
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
                coleccion.Add(Convert.ToString(row["Nombre"]));
            }
            return coleccion;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Ut_ValidaRut u = new Ut_ValidaRut();
            Bu_CuadernoOralne bu = new Bu_CuadernoOralne();
            En_CuadernoRegistraMedico m = new En_CuadernoRegistraMedico();
            if (txtNombre.Text.Trim().ToUpper()!=""&&txtPaterno.Text.Trim().ToUpper() != ""&&txtMaterno.Text.Trim().ToUpper() != "" &&cmbEspecialidad.Text!="")
            {
                if (u.validarRut(txtRut.Text.Trim().ToUpper()))
                {
                    m.rut = u.dni;
                    m.dv = u.digi;
                    m.nombre = txtNombre.Text.Trim().ToUpper();
                    m.paterno = txtPaterno.Text.Trim().ToUpper();
                    m.materno = txtMaterno.Text.Trim().ToUpper();
                    m.especialidad = cmbEspecialidad.Text;
                    m.nacimiento = DateTime.Parse(dtNacimiento.Text);
                    m.email = txtEmail.Text.Trim().ToUpper();
                    m.fono = txtFono.Text.Trim().ToUpper();

                    if (bu.CuadernoRegistraMedico(m) == 1)
                    {
                        MessageBox.Show("Medico registrado con Exito");
                        Dispose();
                        respuesta = true;
                    }
                    else
                    {
                        MessageBox.Show("Medico Existe Porfavor Valide Rut!!!");
                        txtRut.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Rut Invalido!!!");
                    txtRut.Focus();
                }
            }
            else
            {
                MessageBox.Show("Para Registrar un Medico a lo menos\ndebe Registrar Nombre Apellidos y Especialidad");
            }
            
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

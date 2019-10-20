using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Empresa
{
    public partial class Form1 : Form
    {
        ClsEmpleado objEmpleado = null;
        ClsEmpleadoMgr objEmpleadoMgr = null;
        DataTable Dtt = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Listar();
            LimpiarCampos();
        }

        private void Guardar()
        {
            objEmpleado = new ClsEmpleado();
            objEmpleado.opc = 2;
            objEmpleado.Cedula = int.Parse(txtcedula.Text);
            objEmpleado.Nombre = txtnombre.Text;
            objEmpleado.Apellido = txtapellido.Text;
            objEmpleado.FNacimiento = dtpfecha.Value;
            objEmpleado.Cargo = Convert.ToInt32(txtcargo.Text);
            objEmpleadoMgr = new ClsEmpleadoMgr(objEmpleado);

            objEmpleadoMgr.Guardar();
            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "MENSAJE");
        }

        private void Listar()
        {
            objEmpleado = new ClsEmpleado();
            objEmpleado.opc = 1;
            objEmpleadoMgr = new ClsEmpleadoMgr(objEmpleado);

            Dtt = new DataTable();
            Dtt = objEmpleadoMgr.Listar();
            if (Dtt.Rows.Count > 0)
                dtgempresa.DataSource = Dtt;

        }

        private void dtgempresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcedula.Text = dtgempresa.Rows[dtgempresa.CurrentRow.Index].Cells[0].Value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
            btneliminar.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Listar();
            
            
        }

        private void Eliminar()
        {
            objEmpleado = new ClsEmpleado();
            objEmpleado.opc = 3;
            objEmpleado.Cedula = Convert.ToInt32(txtcedula.Text);
            objEmpleadoMgr = new ClsEmpleadoMgr(objEmpleado);

            objEmpleadoMgr.EliminarDatos();
            MessageBox.Show("Datos eliminados");

            dtgempresa.Focus();
        }

        private void LimpiarCampos()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
           
            txtcedula.Focus();
        }

        private void dtgempresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcedula.Text = dtgempresa.Rows[dtgempresa.CurrentRow.Index].Cells[1].Value.ToString();
            txtnombre.Text = dtgempresa.Rows[dtgempresa.CurrentRow.Index].Cells[2].Value.ToString();
            txtapellido.Text = dtgempresa.Rows[dtgempresa.CurrentRow.Index].Cells[3].Value.ToString();
            txtcargo.Text = dtgempresa.Rows[dtgempresa.CurrentRow.Index].Cells[4].Value.ToString();

            btnguardar.Enabled = false;
            btneliminar.Enabled = true;
        }
    }
}

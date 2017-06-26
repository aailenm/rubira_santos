﻿using System;
using System.Data;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol {
    public partial class Modificar_Rol : Form {
        public Modificar_Rol() {
            InitializeComponent();
        }

        private void getFuncionalidades() {
            clbFuncionalidades.DataSource = Conexion.cargarTablaConsulta("GET_FUNCIONALIDADES");
            clbFuncionalidades.ValueMember = "func_id";
            clbFuncionalidades.DisplayMember = "func_descripcion";
        }

        private void refrescarRoles() {
            cmbRol.DataSource = Conexion.obtenerTablaProcedure("GET_ROLES", Conexion.generarArgumentos("@DESCRIPCION"), "");
            cmbRol.SelectedIndex = 0;
            txtDesc.Text = cmbRol.Text;
            cmbRol.Focus();
        }

        private void refrescarFuncionalidades() {
            for (int i = 0; i < clbFuncionalidades.Items.Count; i++) clbFuncionalidades.SetItemChecked(i, false);
            DataTable dt = Conexion.obtenerTablaProcedure("GET_FUNCIONALIDAD_POR_ROL", Conexion.generarArgumentos("@ROL"), cmbRol.SelectedValue);
            foreach (DataRow row in dt.Rows) {
                int id = (int) row["func_id"];
                for (int i = 0; i < clbFuncionalidades.Items.Count; i++) {
                    DataRowView drv = (DataRowView) clbFuncionalidades.Items[i];
                    if ((int) drv.Row["func_id"] == id) {
                        clbFuncionalidades.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e) {
            bool éxito = true;
            if (Conexion.executeProcedure("BORRAR_FUNCIONALIDADES", Conexion.generarArgumentos("@ROL"), cmbRol.SelectedValue)) {
                if (Conexion.executeProcedure("MODIFICAR_ROL", Conexion.generarArgumentos("@ID", "@DESC"), cmbRol.SelectedValue, txtDesc.Text)) {
                    foreach (DataRowView rowView in clbFuncionalidades.CheckedItems) {
                        éxito = Conexion.executeProcedure("AGREGAR_FUNCIONALIDAD", Conexion.generarArgumentos("@FUNCIONALIDAD", "@ROL"), rowView["func_id"], cmbRol.SelectedValue);
                        if (!éxito) break;
                    }
                } else éxito = false;
            } else éxito = false;
            if (éxito) MessageBox.Show("Rol modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Hubo un error al modificar el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            refrescarRoles();
        }

        private void ModificarRol_Load(object sender, EventArgs e) {
            cmbRol.ValueMember = "rol_id";
            cmbRol.DisplayMember = "rol_descripcion";
            getFuncionalidades();
            refrescarRoles();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e) {
            txtDesc.Text = cmbRol.Text;
            refrescarFuncionalidades();
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }
    }
}

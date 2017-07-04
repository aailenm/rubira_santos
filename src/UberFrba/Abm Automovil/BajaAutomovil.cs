﻿using System;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil {
    public partial class Baja_Automovil : Form {
        public Baja_Automovil() {
            InitializeComponent();
        }

        private void refrescarPatentes() {
            cmbPatente.DataSource = Conexion.cargarTablaConsulta("GET_PATENTES");
            cmbPatente.SelectedIndex = -1;
            cmbPatente.Focus();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbPatente.Text))
            {
                MessageBox.Show("Elija un auto");
            }
            else
            {
                if (Conexion.executeProcedure("BAJA_AUTOMOVIL", Conexion.generarArgumentos("@ID"), cmbPatente.SelectedValue))
                    MessageBox.Show("Auto dado de baja", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refrescarPatentes();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            Close();
        }

        private void BajaAutomovil_Load(object sender, EventArgs e) {
            cmbPatente.ValueMember = "auto_id";
            cmbPatente.DisplayMember = "auto_patente";
            refrescarPatentes();
        }

        private void cmbPatente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

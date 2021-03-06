﻿using System;
using System.Windows.Forms;

namespace UberFrba.Login {
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void inicializarCombo(ComboBox combo)
        { 
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (validacion()) {
               bool usuarioCorrecto = Conexion.executeProcedure("GET_USUARIO", Conexion.generarArgumentos("@USUARIO", "@CONTRASEÑA"), usuario.Text, contraseña.Text);
               if (usuarioCorrecto)
               {
                   ElegirRol roles = new ElegirRol();
                   roles.Show();
                   roles.setCombo(Conexion.obtenerTablaProcedure("GET_ROLES_POR_USUARIO", Conexion.generarArgumentos("@USUARIO"), usuario.Text));
                   this.Hide();
               }
            }
        }

        private bool validacion() {
            if (usuario.Text == "") {
                MessageBox.Show("Ingrese su usuario");
                return false;
            }
            if (contraseña.Text == "")
            {
                MessageBox.Show("Ingrese su contraseña");
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Usuario.AltaUsuario nuevoUsuario = new Abm_Usuario.AltaUsuario();
            nuevoUsuario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UberFrba.Abm_Usuario
{
    public partial class AltaUsuario : Form
    {
        bool choferChequeado = false;
        bool clienteChequeado = false;
        public AltaUsuario()
        {
            InitializeComponent();
            mostrarRoles();
            fechanac.Value = Funciones.ObtenerFecha();
            habilitarDatos(false);
        }

        private void habilitarDatos(bool estado)
        {
            nomb.Enabled = estado;
            apell.Enabled = estado; 
            dni.Enabled = estado; 
            mail.Enabled = estado; 
            fechanac.Enabled = estado;
            calle.Enabled = estado;
            piso.Enabled = estado;
            dpto.Enabled = estado;
            local.Enabled = estado;
            cp.Enabled = estado;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private bool validaciones() {
            if (usuario.Text == "") {
                MessageBox.Show("Ingrese un usuario");
                return false;
            }

            if (contraseña.Text == "") {
                MessageBox.Show("Ingrese una contraseña");
                return false;
            }

            if (!(Funciones.esNumero(tel.Text)))
            {
                MessageBox.Show("Solo se aceptan numeros en el Telefono");
                return false;
            }
            if (!(Funciones.esString(local.Text)))
            {
                MessageBox.Show("Solo se aceptan letras en la localidad");
                return false;
            }
           
            if (!(Funciones.esString(nomb.Text)))
            {
                MessageBox.Show("Solo se aceptan letras en el nombre ");
                return false;
            }
            if(!(Funciones.esString(apell.Text)))
            {
                MessageBox.Show("Solo se aceptan letras en el apellido");
                return false;
            }

            if (roles.CheckedItems.Count == 0) {
                MessageBox.Show("Debe seleccionar al menos un rol");
                return false;
            }
            if (dni.Enabled == true)
            {
                if (!(Funciones.esNumero(dni.Text)))
                {
                    MessageBox.Show("Solo se aceptan numeros en el DNI");
                    return false;
                }
                if (!(Funciones.esNumero(cp.Text)))
                {
                    MessageBox.Show("Solo se aceptan numeros en el Codigo Postal");
                    return false;
                }
                if (dni.Text.Length > 8)
                {
                    MessageBox.Show("El numero de dni no puede tener mas de ocho digitos");
                    return false;
                }
                if (tel.Text.Length > 15)
                {
                    MessageBox.Show("El numero de telefono no puede tener mas de quince digitos");
                    return false;
                }

                if (piso.Text.Length > 4)
                {
                    MessageBox.Show("El piso no puede tener mas de cuatro digitos");
                    return false;
                }

                if (dpto.Text.Length > 4)
                {
                    MessageBox.Show("El depto no puede tener mas de cuatro digitos");
                    return false;
                }
                if (nomb.Text == "")
                {
                    MessageBox.Show("El campo Nombre no puede estar vacio");
                    return false;
                }

                if (apell.Text == "")
                {
                    MessageBox.Show("El campo Apellido no puede estar vacio");
                    return false;
                }
                if (dni.Text == "")
                {
                    MessageBox.Show("El campo DNI no puede estar vacio");
                    return false;
                }

                if (mail.Text == "")
                {
                    MessageBox.Show("El campo mail no puede estar vacio");
                    return false;
                }

                if (tel.Text == "")
                {
                    MessageBox.Show("El campo Telefono no puede estar vacio");
                    return false;
                }

                if (fechanac.Value >= Funciones.ObtenerFecha())
                {
                    MessageBox.Show("La fecha de nacimiento es incorrecta");
                    return false;
                }

                if (calle.Text == "")
                {
                    MessageBox.Show("El campo calle no puede estar vacía");
                    return false;
                }

                if (cp.Text == "")
                {
                    MessageBox.Show("El campo codigo postal no puede estar vacía");
                    return false;
                }
         
                if (local.Text == "")
                {
                    MessageBox.Show("El campo localidad no puede estar vacía");
                    return false;
                }
                return true;
            }
            return true;
        }

        private void mostrarRoles(){
            roles.DataSource = Conexion.obtenerTablaProcedure("GET_ROLES",Conexion.generarArgumentos("@DESCRIPCION"),"");
            roles.ValueMember = "rol_id";
            roles.DisplayMember = "rol_descripcion";
        }
        private void agregarRoles()
        {
            SqlDataReader reader = Conexion.ejecutarQuery("Select usua_id from RUBIRA_SANTOS.USUARIO WHERE usua_usuario like '%" + tel.Text + "%'");
            reader.Read();
            string usua = (reader["usua_id"].ToString());
            reader.Close();
            foreach (DataRowView rowView in roles.CheckedItems)
            {
                Conexion.executeProcedure("AGREGAR_ROLES", Conexion.generarArgumentos("@USUARIO", "@ROL"), usua, rowView["rol_id"]);
                if (rowView["rol_descripcion"].ToString() == "Cliente")
                {
                    Conexion.executeProcedure("ALTA_CLIENTE", Conexion.generarArgumentos("@NOMBRE", "@APELLIDO", "@DNI", "@TELEFONO", "@MAIL", "@FECHA_NACIMIENTO", "@CALLE", "@PISO", "@DPTO", "@LOCALIDAD", "@CP", "@USUARIO"),
                nomb.Text, apell.Text, dni.Text, tel.Text, mail.Text, fechanac.Value.ToShortDateString(), calle.Text, piso.Text, dpto.Text, local.Text, cp.Text, usua);
                }
                else
                {
                    if (rowView["rol_descripcion"].ToString() == "Chofer")
                    {
                        Conexion.executeProcedure("ALTA_CHOFER", Conexion.generarArgumentos("@NOMBRE", "@APELLIDO", "@DNI", "@MAIL", "@TELEFONO", "@FECHA_NACIMIENTO", "@CALLE", "@PISO", "@DPTO", "@LOCALIDAD", "@CP", "@USUARIO"),
                nomb.Text, apell.Text, dni.Text, mail.Text, tel.Text, fechanac.Value.ToShortDateString(), calle.Text, piso.Text, dpto.Text, local.Text, cp.Text,usua);
                    }
                }
            }
        }

        private void tel_TextChanged(object sender, EventArgs e)
        {
            usuario.Text = tel.Text;
        }

        private void Limpiar()
        {
            nomb.Clear();
            apell.Clear();
            dni.Clear();
            tel.Clear();
            mail.Clear();
            fechanac.Value = Funciones.ObtenerFecha();
            calle.Clear();
            piso.Clear();
            dpto.Clear();
            local.Clear();
            cp.Clear();
            usuario.Clear();
            contraseña.Clear();
            roles.ClearSelected();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (validaciones())
            {
                bool resultadoUsuario = Conexion.executeProcedure("ALTA_USUARIO", Conexion.generarArgumentos("@USUARIO", "@CONTRA"), usuario.Text, contraseña.Text);
                if (resultadoUsuario)
                {
                    agregarRoles();
                    MessageBox.Show("Usuario creado correctamente. Su usuario es su numero de telefono");
                    Close();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void fechanac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roles_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void roles_CausesValidationChanged(object sender, EventArgs e)
        {
           
        }

        private void roles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            DataRowView data = roles.Items[e.Index] as DataRowView;
            if (data.Row["rol_id"].ToString() == "2")
            {
                if (!roles.CheckedItems.Contains(data)) clienteChequeado = true;
                else clienteChequeado = false;
            }
            if (data.Row["rol_id"].ToString() == "3")
            {
                if (!roles.CheckedItems.Contains(data)) choferChequeado = true;
                else choferChequeado = false;
            }
            if (clienteChequeado || choferChequeado) habilitarDatos(true);
            else habilitarDatos(false);
        }

        private void apell_TextChanged(object sender, EventArgs e)
        {

        }

        private void dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void piso_TextChanged(object sender, EventArgs e)
        {

        }

        private void local_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

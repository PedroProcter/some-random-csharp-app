﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static string user;
        public static string User { get => user; set => user = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            if (txtUser.Text == "Bryan" || txtPass.Text == "Admin")
            {
                this.Close();
                User = "Bryan";
                formulario.Show();
            }else if (txtUser.Text == "Johanny" || txtPass.Text == "Admin")
            {
                User = "Johanny";
                this.Close();
                formulario.Show();
            }
            else if (txtUser.Text == "Pedro" || txtPass.Text == "Admin")
            {
                User = "Pedro";
                this.Close();
                formulario.Show();
            }else
            {
                MessageBox.Show("Ha ingresado una contraseña incorrecta");
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {

            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}

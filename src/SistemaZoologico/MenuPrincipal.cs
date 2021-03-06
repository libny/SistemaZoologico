﻿using System;
using System.Windows.Forms;
using SistemaZoologico.Animales;
using SistemaZoologico.Usuarios;
using SistemaZoologico.VentaBoletos;

namespace SistemaZoologico
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var venta = new VentaBoletos.VentaBoletos())
            {
                venta.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var tipo = new CrearTipoBoletos())
            {
                tipo.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var listadeboletos = new ListarTipoDeBoletos())
            {
                listadeboletos.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var animales = new CreacionAnimales())
            {
                animales.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var especie = new CrearEspecie())
            {
                especie.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var listar = new ListarAnimales())
            {
                listar.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var listar = new ListarEspecie())
            {
                listar.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var usuario = new CreacionUsuarios())
            {
                {
                    usuario.ShowDialog();
                }
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            var inica = new IniciarSesion();

            var usuario = inica.ObtenerUsuario();
            if(usuario == null)Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico
{
    public partial class Form1 : Form
    {
        
        private ServicioVentaBoletos _servicioVentaBoletos =new ServicioVentaBoletos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           comboxtipodeboleto.DataSource = _servicioVentaBoletos.ObtenerTipoBoletos() ;
        }
    }
}
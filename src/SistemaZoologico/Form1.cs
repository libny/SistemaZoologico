using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaZoologico
{
    public partial class Form1 : Form
    {
        private List<TipoBoleto> _tipoBoletos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tipoBoletos = new List<TipoBoleto>();
            _tipoBoletos.Add(new TipoBoleto("Adulto", 80.2f));
            comboxtipodeboleto.DataSource = _tipoBoletos;
        }
    }

    public class TipoBoleto
    {
        public TipoBoleto(string nombre, float precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public string Nombre { get; set; }

        public float Precio { get; set; }
    }
}
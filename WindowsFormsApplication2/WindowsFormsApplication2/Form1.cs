﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace WindowsFormsApplication2
{
    public partial class Operaciones : Form
    {
        Suma ingreso;
        Resta rest;
        Multiplicacion multi;
        Division div;
        public Operaciones()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            ingreso = new Suma();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);
            lblResult.Text=Convert.ToString(ingreso.Calcular());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rest = new Resta();
            rest.R11 = double.Parse(txtValA.Text);
            rest.R21 = double.Parse(txtValB.Text);

            lblResult.Text = Convert.ToString(rest.Calcular());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            multi = new Multiplicacion();
            multi.M1 = double.Parse(txtValA.Text);
            multi.M2 = double.Parse(txtValB.Text);

            lblResult.Text = Convert.ToString(multi.Calcular());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            div = new Division();
            div.D1 = double.Parse(txtValA.Text);
            div.D2 = double.Parse(txtValB.Text);

            lblResult.Text = Convert.ToString(div.Calcular());
        }
    }
}

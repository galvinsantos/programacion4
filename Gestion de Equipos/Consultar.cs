﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Equipos
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            cbtipobusqueda.SelectedValue = 1;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipov1
{
    public partial class MenuSaidaBazar : Form
    {
        public MenuSaidaBazar()
        {
            InitializeComponent();
        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.ShowDialog();
        }

        private void btCriarBazar_Click(object sender, EventArgs e)
        {
            MenuBazar menuBazar = new MenuBazar();
            menuBazar.ShowDialog();
        }
    }
}

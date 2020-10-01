﻿using AppSystem.Data;
using AppSystem.Forms;
using System;
using System.Windows.Forms;

namespace AppSystem
{
    public partial class FrmInit : Form
    {
        protected Database Database { get; private set; }
        public FrmInit()
        {
            InitializeComponent();
            ConfigInit();
        }

        private void ConfigInit()
        {
            Database = new Database(Config.ConnectionString);
        }

        private void FrmInit_Load(object sender, EventArgs e)
        {
        }

        private void unidadeFederativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUfList form = new FrmUfList(Database);
            form.ShowDialog();
        }
    }
}
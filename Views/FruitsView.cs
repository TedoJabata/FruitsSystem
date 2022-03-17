﻿using FruitsSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitsSystem.Views
{
    public partial class FruitsView : Form
    {

        MainController mainController = new MainController();

        public FruitsView()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dgvFruits.DataSource = mainController.ShowAllFruits();
        }

        private void FruitsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fruitsDBDataSet.Fruit' table. You can move, or remove it, as needed.
            this.fruitTableAdapter.Fill(this.fruitsDBDataSet.Fruit);
            RefreshTable();
        }
    }
}
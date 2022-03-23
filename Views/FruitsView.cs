using FruitsSystem.Controller;
using FruitsSystem.Model;
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

        private void btnCreateFruit_Click(object sender, EventArgs e)
        {
            Fruit fruit = new Fruit();
            fruit.Name = txtName.Text;
            fruit.Price = double.Parse(txtPrice.Text);
            fruit.Sugar = double.Parse(txtSugar.Text);
            fruit.Color = txtColor.Text;
            mainController.CreateFruit(fruit);
            RefreshTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFruits.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Fruit fruit = new Fruit();
            fruit.Name = txtName.Text;
            fruit.Price = double.Parse(txtPrice.Text);
            fruit.Sugar = double.Parse(txtSugar.Text);
            fruit.Color = txtColor.Text;
            mainController.UpdateFruit(id, fruit);
            RefreshTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFruits.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            mainController.DeleteFruit(id);
            RefreshTable();
        }
    }
}

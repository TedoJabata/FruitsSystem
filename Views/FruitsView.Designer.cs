
namespace FruitsSystem.Views
{
    partial class FruitsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvFruits = new System.Windows.Forms.DataGridView();
            this.fruitsDBDataSet = new FruitsSystem.FruitsDBDataSet();
            this.fruitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fruitTableAdapter = new FruitsSystem.FruitsDBDataSetTableAdapters.FruitTableAdapter();
            this.fruitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFruits
            // 
            this.dgvFruits.AutoGenerateColumns = false;
            this.dgvFruits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sugarDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dgvFruits.DataSource = this.fruitBindingSource1;
            this.dgvFruits.Location = new System.Drawing.Point(194, 12);
            this.dgvFruits.Name = "dgvFruits";
            this.dgvFruits.Size = new System.Drawing.Size(393, 261);
            this.dgvFruits.TabIndex = 0;
            // 
            // fruitsDBDataSet
            // 
            this.fruitsDBDataSet.DataSetName = "FruitsDBDataSet";
            this.fruitsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fruitBindingSource
            // 
            this.fruitBindingSource.DataMember = "Fruit";
            this.fruitBindingSource.DataSource = this.fruitsDBDataSet;
            // 
            // fruitTableAdapter
            // 
            this.fruitTableAdapter.ClearBeforeFill = true;
            // 
            // fruitBindingSource1
            // 
            this.fruitBindingSource1.DataSource = typeof(FruitsSystem.Model.Fruit);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // sugarDataGridViewTextBoxColumn
            // 
            this.sugarDataGridViewTextBoxColumn.DataPropertyName = "Sugar";
            this.sugarDataGridViewTextBoxColumn.HeaderText = "Sugar";
            this.sugarDataGridViewTextBoxColumn.Name = "sugarDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // FruitsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FruitsSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFruits);
            this.Name = "FruitsView";
            this.Text = "FruitsView";
            this.Load += new System.EventHandler(this.FruitsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFruits;
        private FruitsDBDataSet fruitsDBDataSet;
        private System.Windows.Forms.BindingSource fruitBindingSource;
        private FruitsDBDataSetTableAdapters.FruitTableAdapter fruitTableAdapter;
        private System.Windows.Forms.BindingSource fruitBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
    }
}
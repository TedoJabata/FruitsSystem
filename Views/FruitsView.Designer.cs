
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
            this.fruitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fruitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSugar = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSugar = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnCreateFruit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFruits
            // 
            this.dgvFruits.AutoGenerateColumns = false;
            this.dgvFruits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruits.DataSource = this.fruitBindingSource1;
            this.dgvFruits.Location = new System.Drawing.Point(12, 12);
            this.dgvFruits.Name = "dgvFruits";
            this.dgvFruits.Size = new System.Drawing.Size(444, 251);
            this.dgvFruits.TabIndex = 0;
            // 
            // fruitBindingSource
            // 
            this.fruitBindingSource.DataMember = "Fruit";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 294);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 39);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(142, 294);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(95, 39);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugar.Location = new System.Drawing.Point(266, 294);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(108, 39);
            this.lblSugar.TabIndex = 3;
            this.lblSugar.Text = "Sugar";
            this.lblSugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(404, 294);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(99, 39);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 364);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 43);
            this.txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(141, 364);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(96, 43);
            this.txtPrice.TabIndex = 6;
            // 
            // txtSugar
            // 
            this.txtSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSugar.Location = new System.Drawing.Point(263, 364);
            this.txtSugar.Multiline = true;
            this.txtSugar.Name = "txtSugar";
            this.txtSugar.Size = new System.Drawing.Size(111, 43);
            this.txtSugar.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(402, 364);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(101, 43);
            this.txtColor.TabIndex = 8;
            // 
            // btnCreateFruit
            // 
            this.btnCreateFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFruit.Location = new System.Drawing.Point(548, 294);
            this.btnCreateFruit.Name = "btnCreateFruit";
            this.btnCreateFruit.Size = new System.Drawing.Size(171, 113);
            this.btnCreateFruit.TabIndex = 9;
            this.btnCreateFruit.Text = "Create Fruit";
            this.btnCreateFruit.UseVisualStyleBackColor = true;
            this.btnCreateFruit.Click += new System.EventHandler(this.btnCreateFruit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(548, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 58);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Fruit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(548, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 58);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Fruit";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FruitsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FruitsSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreateFruit);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtSugar);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblSugar);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvFruits);
            this.Name = "FruitsView";
            this.Text = "FruitsView";
            this.Load += new System.EventHandler(this.FruitsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSugar;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnCreateFruit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
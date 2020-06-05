namespace PracticaBurguerLaura
{
    partial class MenuOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EliminarButton = new PracticaBurguerLaura.CircularButton();
            this.dataGridPedido = new System.Windows.Forms.DataGridView();
            this.BottonPagar = new PracticaBurguerLaura.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(208, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 46);
            this.label2.TabIndex = 29;
            this.label2.Text = "ORDERS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PracticaBurguerLaura.Properties.Resources.fondoPanelForms1;
            this.pictureBox1.Image = global::PracticaBurguerLaura.Properties.Resources.DELETE;
            this.pictureBox1.Location = new System.Drawing.Point(556, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 68);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.Color.DarkRed;
            this.EliminarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EliminarButton.BackgroundImage")));
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EliminarButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.EliminarButton.FlatAppearance.BorderSize = 0;
            this.EliminarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.EliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarButton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ForeColor = System.Drawing.Color.Transparent;
            this.EliminarButton.Location = new System.Drawing.Point(593, 145);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(137, 137);
            this.EliminarButton.TabIndex = 7;
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // dataGridPedido
            // 
            this.dataGridPedido.AllowUserToAddRows = false;
            this.dataGridPedido.AllowUserToDeleteRows = false;
            this.dataGridPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedido.EnableHeadersVisualStyles = false;
            this.dataGridPedido.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridPedido.Location = new System.Drawing.Point(25, 127);
            this.dataGridPedido.Name = "dataGridPedido";
            this.dataGridPedido.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPedido.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPedido.Size = new System.Drawing.Size(523, 338);
            this.dataGridPedido.TabIndex = 28;
            this.dataGridPedido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridPedido_MouseClick);
            // 
            // BottonPagar
            // 
            this.BottonPagar.BackColor = System.Drawing.Color.Indigo;
            this.BottonPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BottonPagar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BottonPagar.FlatAppearance.BorderSize = 0;
            this.BottonPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkMagenta;
            this.BottonPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.BottonPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottonPagar.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottonPagar.ForeColor = System.Drawing.Color.Transparent;
            this.BottonPagar.Image = global::PracticaBurguerLaura.Properties.Resources.paYnow;
            this.BottonPagar.Location = new System.Drawing.Point(593, 328);
            this.BottonPagar.Name = "BottonPagar";
            this.BottonPagar.Size = new System.Drawing.Size(137, 137);
            this.BottonPagar.TabIndex = 5;
            this.BottonPagar.UseVisualStyleBackColor = false;
            // 
            // MenuOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PracticaBurguerLaura.Properties.Resources.fondoPanelForms1;
            this.ClientSize = new System.Drawing.Size(772, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridPedido);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BottonPagar);
            this.Name = "MenuOrders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton EliminarButton;
        private System.Windows.Forms.DataGridView dataGridPedido;
        private CircularButton BottonPagar;
    }
}
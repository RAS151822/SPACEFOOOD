namespace PracticaBurguerLaura
{
    partial class MenuCarrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCarrito));
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.BottonPagar = new PracticaBurguerLaura.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circularButton1 = new PracticaBurguerLaura.CircularButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 442);
            this.panel1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(410, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 442);
            this.vScrollBar1.TabIndex = 0;
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
            this.BottonPagar.Location = new System.Drawing.Point(545, 305);
            this.BottonPagar.Name = "BottonPagar";
            this.BottonPagar.Size = new System.Drawing.Size(137, 137);
            this.BottonPagar.TabIndex = 1;
            this.BottonPagar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PracticaBurguerLaura.Properties.Resources.fondoPanelForms1;
            this.pictureBox1.Image = global::PracticaBurguerLaura.Properties.Resources.DELETE;
            this.pictureBox1.Location = new System.Drawing.Point(520, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 68);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.DarkRed;
            this.circularButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton1.BackgroundImage")));
            this.circularButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circularButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.circularButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton1.ForeColor = System.Drawing.Color.Transparent;
            this.circularButton1.Location = new System.Drawing.Point(545, 105);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(137, 137);
            this.circularButton1.TabIndex = 4;
            this.circularButton1.UseVisualStyleBackColor = false;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PracticaBurguerLaura.Properties.Resources.fondoPanelForms1;
            this.ClientSize = new System.Drawing.Size(772, 466);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BottonPagar);
            this.Controls.Add(this.panel1);
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private CircularButton BottonPagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton circularButton1;
    }
}
using System.Windows.Forms;

namespace Tp1_Definitivo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.caballero4 = new System.Windows.Forms.PictureBox();
            this.caballero3 = new System.Windows.Forms.PictureBox();
            this.caballero2 = new System.Windows.Forms.PictureBox();
            this.caballero1 = new System.Windows.Forms.PictureBox();
            this.Tablero = new System.Windows.Forms.PictureBox();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btJuego = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.j1d1 = new System.Windows.Forms.PictureBox();
            this.j1d2 = new System.Windows.Forms.PictureBox();
            this.j2d1 = new System.Windows.Forms.PictureBox();
            this.j2d2 = new System.Windows.Forms.PictureBox();
            this.j3d1 = new System.Windows.Forms.PictureBox();
            this.j3d2 = new System.Windows.Forms.PictureBox();
            this.j4d1 = new System.Windows.Forms.PictureBox();
            this.j4d2 = new System.Windows.Forms.PictureBox();
            this.btnGanadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.caballero4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballero3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j1d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j1d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j2d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j2d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j3d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j3d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j4d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j4d2)).BeginInit();
            this.SuspendLayout();
            // 
            // caballero4
            // 
            this.caballero4.BackColor = System.Drawing.SystemColors.Control;
            this.caballero4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("caballero4.BackgroundImage")));
            this.caballero4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caballero4.Image = ((System.Drawing.Image)(resources.GetObject("caballero4.Image")));
            this.caballero4.Location = new System.Drawing.Point(46, 12);
            this.caballero4.Name = "caballero4";
            this.caballero4.Size = new System.Drawing.Size(33, 39);
            this.caballero4.TabIndex = 14;
            this.caballero4.TabStop = false;
            this.caballero4.Visible = false;
            // 
            // caballero3
            // 
            this.caballero3.BackColor = System.Drawing.SystemColors.Control;
            this.caballero3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("caballero3.BackgroundImage")));
            this.caballero3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caballero3.Image = ((System.Drawing.Image)(resources.GetObject("caballero3.Image")));
            this.caballero3.Location = new System.Drawing.Point(7, 57);
            this.caballero3.Name = "caballero3";
            this.caballero3.Size = new System.Drawing.Size(33, 39);
            this.caballero3.TabIndex = 13;
            this.caballero3.TabStop = false;
            this.caballero3.Visible = false;
            // 
            // caballero2
            // 
            this.caballero2.BackColor = System.Drawing.SystemColors.Control;
            this.caballero2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("caballero2.BackgroundImage")));
            this.caballero2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caballero2.Image = ((System.Drawing.Image)(resources.GetObject("caballero2.Image")));
            this.caballero2.Location = new System.Drawing.Point(46, 57);
            this.caballero2.Name = "caballero2";
            this.caballero2.Size = new System.Drawing.Size(33, 39);
            this.caballero2.TabIndex = 12;
            this.caballero2.TabStop = false;
            this.caballero2.Visible = false;
            // 
            // caballero1
            // 
            this.caballero1.BackColor = System.Drawing.SystemColors.Control;
            this.caballero1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("caballero1.BackgroundImage")));
            this.caballero1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caballero1.Image = ((System.Drawing.Image)(resources.GetObject("caballero1.Image")));
            this.caballero1.Location = new System.Drawing.Point(7, 12);
            this.caballero1.Name = "caballero1";
            this.caballero1.Size = new System.Drawing.Size(33, 39);
            this.caballero1.TabIndex = 10;
            this.caballero1.TabStop = false;
            this.caballero1.Visible = false;
            // 
            // Tablero
            // 
            this.Tablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tablero.Image = ((System.Drawing.Image)(resources.GetObject("Tablero.Image")));
            this.Tablero.Location = new System.Drawing.Point(-1, -6);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(1217, 631);
            this.Tablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tablero.TabIndex = 1;
            this.Tablero.TabStop = false;
            this.Tablero.Click += new System.EventHandler(this.Tablero_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.Color.Thistle;
            this.btnDemo.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.btnDemo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDemo.Location = new System.Drawing.Point(1047, 12);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(114, 46);
            this.btnDemo.TabIndex = 15;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = false;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btJuego
            // 
            this.btJuego.BackColor = System.Drawing.Color.Thistle;
            this.btJuego.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.btJuego.Location = new System.Drawing.Point(1058, 433);
            this.btJuego.Name = "btJuego";
            this.btJuego.Size = new System.Drawing.Size(114, 46);
            this.btJuego.TabIndex = 16;
            this.btJuego.Text = "Jugar";
            this.btJuego.UseVisualStyleBackColor = false;
            this.btJuego.Click += new System.EventHandler(this.btJuego_Click);
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.Thistle;
            this.btnMover.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMover.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.btnMover.Location = new System.Drawing.Point(1058, 485);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(114, 46);
            this.btnMover.TabIndex = 17;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = false;
            this.btnMover.Visible = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // j1d1
            // 
            this.j1d1.BackColor = System.Drawing.Color.DarkGray;
            this.j1d1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("j1d1.BackgroundImage")));
            this.j1d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.j1d1.Image = global::Tp1_Definitivo.Properties.Resources.Ultimointentodragon;
            this.j1d1.Location = new System.Drawing.Point(1036, 185);
            this.j1d1.Name = "j1d1";
            this.j1d1.Size = new System.Drawing.Size(42, 46);
            this.j1d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.j1d1.TabIndex = 18;
            this.j1d1.TabStop = false;
            this.j1d1.Visible = false;
            // 
            // j1d2
            // 
            this.j1d2.BackColor = System.Drawing.Color.DarkGray;
            this.j1d2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("j1d2.BackgroundImage")));
            this.j1d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.j1d2.Image = global::Tp1_Definitivo.Properties.Resources.Ultimointentodragon;
            this.j1d2.Location = new System.Drawing.Point(1100, 185);
            this.j1d2.Name = "j1d2";
            this.j1d2.Size = new System.Drawing.Size(42, 46);
            this.j1d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.j1d2.TabIndex = 21;
            this.j1d2.TabStop = false;
            this.j1d2.Visible = false;
            // 
            // j2d1
            // 
            this.j2d1.BackColor = System.Drawing.Color.DarkGray;
            this.j2d1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("j2d1.BackgroundImage")));
            this.j2d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.j2d1.Image = global::Tp1_Definitivo.Properties.Resources.d2_removebg_preview;
            this.j2d1.Location = new System.Drawing.Point(1100, 237);
            this.j2d1.Name = "j2d1";
            this.j2d1.Size = new System.Drawing.Size(42, 46);
            this.j2d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.j2d1.TabIndex = 23;
            this.j2d1.TabStop = false;
            this.j2d1.Visible = false;
            // 
            // j2d2
            // 
            this.j2d2.BackColor = System.Drawing.Color.DarkGray;
            this.j2d2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("j2d2.BackgroundImage")));
            this.j2d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.j2d2.Image = global::Tp1_Definitivo.Properties.Resources.d2_removebg_preview;
            this.j2d2.Location = new System.Drawing.Point(1036, 237);
            this.j2d2.Name = "j2d2";
            this.j2d2.Size = new System.Drawing.Size(42, 46);
            this.j2d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.j2d2.TabIndex = 24;
            this.j2d2.TabStop = false;
            this.j2d2.Visible = false;
            // 
            // j3d1
            // 
            this.j3d1.BackColor = System.Drawing.Color.DarkGray;
            this.j3d1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("j3d1.BackgroundImage")));
            this.j3d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.j3d1.Image = global::Tp1_Definitivo.Properties.Resources.d3_removebg_preview;
            this.j3d1.Location = new System.Drawing.Point(1100, 301);
            this.j3d1.Name = "j3d1";
            this.j3d1.Size = new System.Drawing.Size(42, 46);
            this.j3d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.j3d1.TabIndex = 25;
            this.j3d1.TabStop = false;
            this.j3d1.Visible = false;
            // 
            // j3d2
            // 
            this.j3d2.BackColor = System.Drawing.Color.DarkGray;
            this.j3d2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("j3d2.BackgroundImage")));
            this.j3d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.j3d2.Image = global::Tp1_Definitivo.Properties.Resources.d3_removebg_preview;
            this.j3d2.Location = new System.Drawing.Point(1036, 301);
            this.j3d2.Name = "j3d2";
            this.j3d2.Size = new System.Drawing.Size(42, 46);
            this.j3d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.j3d2.TabIndex = 26;
            this.j3d2.TabStop = false;
            this.j3d2.Visible = false;
            // 
            // j4d1
            // 
            this.j4d1.BackColor = System.Drawing.Color.DarkGray;
            this.j4d1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("j4d1.BackgroundImage")));
            this.j4d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.j4d1.Image = global::Tp1_Definitivo.Properties.Resources.d4_removebg_preview;
            this.j4d1.Location = new System.Drawing.Point(1100, 353);
            this.j4d1.Name = "j4d1";
            this.j4d1.Size = new System.Drawing.Size(42, 46);
            this.j4d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.j4d1.TabIndex = 27;
            this.j4d1.TabStop = false;
            this.j4d1.Visible = false;
            // 
            // j4d2
            // 
            this.j4d2.BackColor = System.Drawing.Color.DarkGray;
            this.j4d2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("j4d2.BackgroundImage")));
            this.j4d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.j4d2.Image = global::Tp1_Definitivo.Properties.Resources.d4_removebg_preview;
            this.j4d2.Location = new System.Drawing.Point(1036, 353);
            this.j4d2.Name = "j4d2";
            this.j4d2.Size = new System.Drawing.Size(42, 46);
            this.j4d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.j4d2.TabIndex = 28;
            this.j4d2.TabStop = false;
            this.j4d2.Visible = false;
            // 
            // btnGanadores
            // 
            this.btnGanadores.BackColor = System.Drawing.Color.Thistle;
            this.btnGanadores.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGanadores.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.btnGanadores.Location = new System.Drawing.Point(1024, 547);
            this.btnGanadores.Name = "btnGanadores";
            this.btnGanadores.Size = new System.Drawing.Size(176, 46);
            this.btnGanadores.TabIndex = 29;
            this.btnGanadores.Text = "Ver ganadores";
            this.btnGanadores.UseVisualStyleBackColor = false;
            this.btnGanadores.Click += new System.EventHandler(this.btnGanadores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 621);
            this.Controls.Add(this.btnGanadores);
            this.Controls.Add(this.j4d2);
            this.Controls.Add(this.j4d1);
            this.Controls.Add(this.j3d2);
            this.Controls.Add(this.j3d1);
            this.Controls.Add(this.j2d2);
            this.Controls.Add(this.j2d1);
            this.Controls.Add(this.j1d2);
            this.Controls.Add(this.j1d1);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btJuego);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.caballero4);
            this.Controls.Add(this.caballero3);
            this.Controls.Add(this.caballero2);
            this.Controls.Add(this.caballero1);
            this.Controls.Add(this.Tablero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Caballeros, Calabozos y Dragones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caballero4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballero3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j1d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j1d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j2d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j2d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j3d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j3d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j4d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j4d2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Tablero;
        private System.Windows.Forms.PictureBox caballero1;
        private System.Windows.Forms.PictureBox caballero2;
        private System.Windows.Forms.PictureBox caballero3;
        private System.Windows.Forms.PictureBox caballero4;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btJuego;
        private System.Windows.Forms.Button btnMover;
        private PictureBox j1d1;
        private PictureBox j1d2;
        private PictureBox j2d1;
        private PictureBox j2d2;
        private PictureBox j3d1;
        private PictureBox j3d2;
        private PictureBox j4d1;
        private PictureBox j4d2;
        private Button btnGanadores;
    }
}


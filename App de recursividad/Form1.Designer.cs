namespace App_de_recursividad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSeleccionarDirectorio = new System.Windows.Forms.Button();
            this.Archivos = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarDirectorio
            // 
            this.btnSeleccionarDirectorio.BackColor = System.Drawing.Color.Turquoise;
            this.btnSeleccionarDirectorio.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionarDirectorio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSeleccionarDirectorio.Location = new System.Drawing.Point(-1, 1);
            this.btnSeleccionarDirectorio.Name = "btnSeleccionarDirectorio";
            this.btnSeleccionarDirectorio.Size = new System.Drawing.Size(535, 37);
            this.btnSeleccionarDirectorio.TabIndex = 0;
            this.btnSeleccionarDirectorio.Text = "Selecciona la ruta del directorio";
            this.btnSeleccionarDirectorio.UseVisualStyleBackColor = false;
            this.btnSeleccionarDirectorio.Click += new System.EventHandler(this.btnSeleccionarDirectorio_Click);
            // 
            // Archivos
            // 
            this.Archivos.Font = new System.Drawing.Font("Gill Sans MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Archivos.FormattingEnabled = true;
            this.Archivos.ItemHeight = 25;
            this.Archivos.Location = new System.Drawing.Point(-1, 34);
            this.Archivos.Name = "Archivos";
            this.Archivos.Size = new System.Drawing.Size(535, 329);
            this.Archivos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_de_recursividad.Properties.Resources.redo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(424, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App_de_recursividad.Properties.Resources.button;
            this.pictureBox2.Location = new System.Drawing.Point(471, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 355);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Archivos);
            this.Controls.Add(this.btnSeleccionarDirectorio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSeleccionarDirectorio;
        private ListBox Archivos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
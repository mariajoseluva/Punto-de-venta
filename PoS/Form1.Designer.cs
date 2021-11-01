
namespace PoS
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
            this.components = new System.ComponentModel.Container();
            this.userL = new System.Windows.Forms.Label();
            this.passL = new System.Windows.Forms.Label();
            this.usuariotxb = new System.Windows.Forms.TextBox();
            this.pswtxb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreTienda = new System.Windows.Forms.Label();
            this.hora_fecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userL.Location = new System.Drawing.Point(281, 152);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(89, 25);
            this.userL.TabIndex = 0;
            this.userL.Text = "Usuario";
            // 
            // passL
            // 
            this.passL.AutoSize = true;
            this.passL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passL.Location = new System.Drawing.Point(281, 209);
            this.passL.Name = "passL";
            this.passL.Size = new System.Drawing.Size(127, 25);
            this.passL.TabIndex = 1;
            this.passL.Text = "Contraseña";
            // 
            // usuariotxb
            // 
            this.usuariotxb.Location = new System.Drawing.Point(417, 150);
            this.usuariotxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usuariotxb.Name = "usuariotxb";
            this.usuariotxb.Size = new System.Drawing.Size(138, 27);
            this.usuariotxb.TabIndex = 2;
            // 
            // pswtxb
            // 
            this.pswtxb.Location = new System.Drawing.Point(417, 207);
            this.pswtxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pswtxb.Name = "pswtxb";
            this.pswtxb.PasswordChar = '•';
            this.pswtxb.Size = new System.Drawing.Size(138, 27);
            this.pswtxb.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreTienda
            // 
            this.nombreTienda.AutoSize = true;
            this.nombreTienda.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nombreTienda.ForeColor = System.Drawing.Color.Blue;
            this.nombreTienda.Location = new System.Drawing.Point(200, 9);
            this.nombreTienda.Name = "nombreTienda";
            this.nombreTienda.Size = new System.Drawing.Size(268, 46);
            this.nombreTienda.TabIndex = 5;
            this.nombreTienda.Text = "Nombre tienda";
            // 
            // hora_fecha
            // 
            this.hora_fecha.AutoSize = true;
            this.hora_fecha.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.hora_fecha.ForeColor = System.Drawing.Color.Blue;
            this.hora_fecha.Location = new System.Drawing.Point(234, 55);
            this.hora_fecha.Name = "hora_fecha";
            this.hora_fecha.Size = new System.Drawing.Size(0, 35);
            this.hora_fecha.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PoS.Properties.Resources.store1;
            this.pictureBox1.Location = new System.Drawing.Point(80, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 122);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(240, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hora y Fecha";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(667, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hora_fecha);
            this.Controls.Add(this.nombreTienda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pswtxb);
            this.Controls.Add(this.usuariotxb);
            this.Controls.Add(this.passL);
            this.Controls.Add(this.userL);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.Label passL;
        private System.Windows.Forms.TextBox usuariotxb;
        private System.Windows.Forms.TextBox pswtxb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nombreTienda;
        private System.Windows.Forms.Label hora_fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}


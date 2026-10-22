namespace Parcial2_1
{
    partial class login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.lblUgb = new System.Windows.Forms.Label();
            this.lblUniversidad = new System.Windows.Forms.Label();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.lblPortal = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlLineaUsuario = new System.Windows.Forms.Panel();
            this.lblClave = new System.Windows.Forms.Label();
            this.pnlClave = new System.Windows.Forms.Panel();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.pnlLineaClave = new System.Windows.Forms.Panel();
            this.chkMostrarClave = new System.Windows.Forms.CheckBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlIzquierdo.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlClave.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlIzquierdo
            //
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(15, 32, 67);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(270, 420);
            this.pnlIzquierdo.TabIndex = 0;
            this.pnlIzquierdo.Controls.Add(this.lblPortal);
            this.pnlIzquierdo.Controls.Add(this.pnlLinea);
            this.pnlIzquierdo.Controls.Add(this.lblUniversidad);
            this.pnlIzquierdo.Controls.Add(this.lblUgb);
            //
            // lblUgb
            //
            this.lblUgb.BackColor = System.Drawing.Color.Transparent;
            this.lblUgb.Font = new System.Drawing.Font("Segoe UI", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUgb.ForeColor = System.Drawing.Color.White;
            this.lblUgb.Location = new System.Drawing.Point(20, 95);
            this.lblUgb.Name = "lblUgb";
            this.lblUgb.Size = new System.Drawing.Size(230, 80);
            this.lblUgb.Text = "UGB";
            this.lblUgb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblUniversidad
            //
            this.lblUniversidad.BackColor = System.Drawing.Color.Transparent;
            this.lblUniversidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversidad.ForeColor = System.Drawing.Color.FromArgb(200, 214, 240);
            this.lblUniversidad.Location = new System.Drawing.Point(24, 178);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(225, 48);
            this.lblUniversidad.Text = "Universidad Gerardo Barrios - Centro Regional Usulután";
            //
            // pnlLinea
            //
            this.pnlLinea.BackColor = System.Drawing.Color.FromArgb(0, 150, 255);
            this.pnlLinea.Location = new System.Drawing.Point(28, 240);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(60, 4);
            //
            // lblPortal
            //
            this.lblPortal.BackColor = System.Drawing.Color.Transparent;
            this.lblPortal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortal.ForeColor = System.Drawing.Color.White;
            this.lblPortal.Location = new System.Drawing.Point(24, 256);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(225, 30);
            this.lblPortal.Text = "Portal de Gestión Académica";
            //
            // pnlDerecho
            //
            this.pnlDerecho.BackColor = System.Drawing.Color.White;
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.TabIndex = 1;
            this.pnlDerecho.Controls.Add(this.btnSalir);
            this.pnlDerecho.Controls.Add(this.btnRegistrarse);
            this.pnlDerecho.Controls.Add(this.btnIngresar);
            this.pnlDerecho.Controls.Add(this.lblIntentos);
            this.pnlDerecho.Controls.Add(this.chkMostrarClave);
            this.pnlDerecho.Controls.Add(this.pnlClave);
            this.pnlDerecho.Controls.Add(this.lblClave);
            this.pnlDerecho.Controls.Add(this.pnlUsuario);
            this.pnlDerecho.Controls.Add(this.lblUsuario);
            this.pnlDerecho.Controls.Add(this.lblTitulo);
            //
            // lblTitulo
            //
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(15, 32, 67);
            this.lblTitulo.Location = new System.Drawing.Point(36, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(350, 46);
            this.lblTitulo.Text = "Bienvenido";
            //
            // lblUsuario
            //
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblUsuario.Location = new System.Drawing.Point(38, 82);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(200, 20);
            this.lblUsuario.Text = "Usuario";
            //
            // pnlUsuario
            //
            this.pnlUsuario.BackColor = System.Drawing.Color.White;
            this.pnlUsuario.Location = new System.Drawing.Point(36, 102);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(350, 36);
            this.pnlUsuario.Controls.Add(this.txtUsuario);
            this.pnlUsuario.Controls.Add(this.pnlLineaUsuario);
            //
            // txtUsuario
            //
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(2, 8);
            this.txtUsuario.MaxLength = 35;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(344, 22);
            this.txtUsuario.TabIndex = 0;
            //
            // pnlLineaUsuario
            //
            this.pnlLineaUsuario.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.pnlLineaUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaUsuario.Name = "pnlLineaUsuario";
            this.pnlLineaUsuario.Size = new System.Drawing.Size(350, 2);
            //
            // lblClave
            //
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblClave.Location = new System.Drawing.Point(38, 148);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(200, 20);
            this.lblClave.Text = "Contraseña";
            //
            // pnlClave
            //
            this.pnlClave.BackColor = System.Drawing.Color.White;
            this.pnlClave.Location = new System.Drawing.Point(36, 168);
            this.pnlClave.Name = "pnlClave";
            this.pnlClave.Size = new System.Drawing.Size(350, 36);
            this.pnlClave.Controls.Add(this.txtClave);
            this.pnlClave.Controls.Add(this.pnlLineaClave);
            //
            // txtClave
            //
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(2, 8);
            this.txtClave.MaxLength = 35;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(344, 22);
            this.txtClave.TabIndex = 1;
            this.txtClave.UseSystemPasswordChar = true;
            //
            // pnlLineaClave
            //
            this.pnlLineaClave.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.pnlLineaClave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaClave.Name = "pnlLineaClave";
            this.pnlLineaClave.Size = new System.Drawing.Size(350, 2);
            //
            // chkMostrarClave
            //
            this.chkMostrarClave.AutoSize = true;
            this.chkMostrarClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarClave.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.chkMostrarClave.Location = new System.Drawing.Point(38, 212);
            this.chkMostrarClave.Name = "chkMostrarClave";
            this.chkMostrarClave.TabIndex = 2;
            this.chkMostrarClave.Text = "Mostrar contraseña";
            this.chkMostrarClave.UseVisualStyleBackColor = true;
            this.chkMostrarClave.CheckedChanged += new System.EventHandler(this.chkMostrarClave_CheckedChanged);
            //
            // lblIntentos
            //
            this.lblIntentos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.ForeColor = System.Drawing.Color.FromArgb(176, 48, 48);
            this.lblIntentos.Location = new System.Drawing.Point(38, 238);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(348, 18);
            this.lblIntentos.Text = "";
            //
            // btnIngresar
            //
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(36, 262);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(350, 42);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Iniciar Sesión";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            //
            // btnRegistrarse
            //
            this.btnRegistrarse.BackColor = System.Drawing.Color.White;
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnRegistrarse.FlatAppearance.BorderSize = 1;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnRegistrarse.Location = new System.Drawing.Point(36, 316);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(210, 36);
            this.btnRegistrarse.TabIndex = 4;
            this.btnRegistrarse.Text = "Crear nueva cuenta";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            //
            // btnSalir
            //
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(235, 238, 243);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.btnSalir.Location = new System.Drawing.Point(258, 316);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            //
            // login
            //
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.pnlIzquierdo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UGB - Iniciar sesión";
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlClave.ResumeLayout(false);
            this.pnlClave.PerformLayout();
            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Label lblUgb;
        private System.Windows.Forms.Label lblUniversidad;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.Label lblPortal;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnlLineaUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Panel pnlClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Panel pnlLineaClave;
        private System.Windows.Forms.CheckBox chkMostrarClave;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnSalir;
    }
}
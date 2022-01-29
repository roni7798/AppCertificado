
using System.Windows.Forms;

namespace AppCertificado
{
    partial class Form1
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
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDescripcionTitulo = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDescripcionTitulo = new System.Windows.Forms.TextBox();
            this.GenerarCertificado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.Location = new System.Drawing.Point(67, 60);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(149, 36);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre del curso";
            this.lblNombreCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(67, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(149, 36);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Alumn@";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(67, 204);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(149, 36);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido Alumn@";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(67, 276);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(149, 36);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI Alumn@";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcionTitulo
            // 
            this.lblDescripcionTitulo.Location = new System.Drawing.Point(67, 346);
            this.lblDescripcionTitulo.Name = "lblDescripcionTitulo";
            this.lblDescripcionTitulo.Size = new System.Drawing.Size(149, 36);
            this.lblDescripcionTitulo.TabIndex = 4;
            this.lblDescripcionTitulo.Text = "Descripción del titulo";
            this.lblDescripcionTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(223, 60);
            this.txtNombreCurso.Multiline = true;
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(866, 35);
            this.txtNombreCurso.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(223, 132);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(866, 35);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(223, 205);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(866, 35);
            this.txtApellido.TabIndex = 7;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(223, 277);
            this.txtDNI.Multiline = true;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(866, 35);
            this.txtDNI.TabIndex = 8;
            // 
            // txtDescripcionTitulo
            // 
            this.txtDescripcionTitulo.AcceptsReturn = true;
            this.txtDescripcionTitulo.AcceptsTab = true;
            this.txtDescripcionTitulo.Location = new System.Drawing.Point(223, 355);
            this.txtDescripcionTitulo.Multiline = true;
            this.txtDescripcionTitulo.Name = "txtDescripcionTitulo";
            this.txtDescripcionTitulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionTitulo.Size = new System.Drawing.Size(866, 120);
            this.txtDescripcionTitulo.TabIndex = 9;
            // 
            // GenerarCertificado
            // 
            this.GenerarCertificado.Location = new System.Drawing.Point(488, 507);
            this.GenerarCertificado.Name = "GenerarCertificado";
            this.GenerarCertificado.Size = new System.Drawing.Size(199, 50);
            this.GenerarCertificado.TabIndex = 10;
            this.GenerarCertificado.Text = "Generar Certificado PDF";
            this.GenerarCertificado.UseVisualStyleBackColor = true;
            this.GenerarCertificado.Click += new System.EventHandler(this.GenerarCertificado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 594);
            this.Controls.Add(this.GenerarCertificado);
            this.Controls.Add(this.txtDescripcionTitulo);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.lblDescripcionTitulo);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNombreCurso);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppCertificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDescripcionTitulo;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtDescripcionTitulo;
        private Button GenerarCertificado;
    }
}


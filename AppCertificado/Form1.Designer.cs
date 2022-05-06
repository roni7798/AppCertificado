
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
            this.lblDescripcionTitulo = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDescripcionTitulo = new System.Windows.Forms.TextBox();
            this.GenerarCertificadoWord = new System.Windows.Forms.Button();
            this.GenerarCertificadoPDF = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.listaDocumentos_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.Location = new System.Drawing.Point(89, 74);
            this.lblNombreCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(199, 44);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre del curso";
            this.lblNombreCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(89, 162);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 44);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Alumn@";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(89, 251);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(199, 44);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido Alumn@";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcionTitulo
            // 
            this.lblDescripcionTitulo.Location = new System.Drawing.Point(89, 426);
            this.lblDescripcionTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionTitulo.Name = "lblDescripcionTitulo";
            this.lblDescripcionTitulo.Size = new System.Drawing.Size(199, 44);
            this.lblDescripcionTitulo.TabIndex = 4;
            this.lblDescripcionTitulo.Text = "Descripción del titulo";
            this.lblDescripcionTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(297, 74);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCurso.Multiline = true;
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(1153, 42);
            this.txtNombreCurso.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(297, 162);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(1153, 42);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(297, 252);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(1153, 42);
            this.txtApellido.TabIndex = 7;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(869, 341);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNI.Multiline = true;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(581, 42);
            this.txtDNI.TabIndex = 8;
            // 
            // txtDescripcionTitulo
            // 
            this.txtDescripcionTitulo.AcceptsReturn = true;
            this.txtDescripcionTitulo.AcceptsTab = true;
            this.txtDescripcionTitulo.Location = new System.Drawing.Point(297, 437);
            this.txtDescripcionTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionTitulo.Multiline = true;
            this.txtDescripcionTitulo.Name = "txtDescripcionTitulo";
            this.txtDescripcionTitulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionTitulo.Size = new System.Drawing.Size(1153, 147);
            this.txtDescripcionTitulo.TabIndex = 9;
            // 
            // GenerarCertificadoWord
            // 
            this.GenerarCertificadoWord.Location = new System.Drawing.Point(431, 630);
            this.GenerarCertificadoWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerarCertificadoWord.Name = "GenerarCertificadoWord";
            this.GenerarCertificadoWord.Size = new System.Drawing.Size(265, 62);
            this.GenerarCertificadoWord.TabIndex = 10;
            this.GenerarCertificadoWord.Text = "Generar Certificado Word";
            this.GenerarCertificadoWord.UseVisualStyleBackColor = true;
            this.GenerarCertificadoWord.Click += new System.EventHandler(this.GenerarCertificadoWord_Click);
            // 
            // GenerarCertificadoPDF
            // 
            this.GenerarCertificadoPDF.Location = new System.Drawing.Point(813, 630);
            this.GenerarCertificadoPDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerarCertificadoPDF.Name = "GenerarCertificadoPDF";
            this.GenerarCertificadoPDF.Size = new System.Drawing.Size(265, 62);
            this.GenerarCertificadoPDF.TabIndex = 11;
            this.GenerarCertificadoPDF.Text = "Generar Certificado PDF";
            this.GenerarCertificadoPDF.UseVisualStyleBackColor = true;
            this.GenerarCertificadoPDF.Click += new System.EventHandler(this.GenerarCertificadoPDF_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(348, 324);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(199, 30);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "Tipo de Documento Alumn@";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaDocumentos_ComboBox
            // 
            this.listaDocumentos_ComboBox.FormattingEnabled = true;
            this.listaDocumentos_ComboBox.Location = new System.Drawing.Point(93, 357);
            this.listaDocumentos_ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaDocumentos_ComboBox.Name = "listaDocumentos_ComboBox";
            this.listaDocumentos_ComboBox.Size = new System.Drawing.Size(767, 24);
            this.listaDocumentos_ComboBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 731);
            this.Controls.Add(this.listaDocumentos_ComboBox);
            this.Controls.Add(this.GenerarCertificadoPDF);
            this.Controls.Add(this.GenerarCertificadoWord);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblDescripcionTitulo;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtDescripcionTitulo;
        private Button GenerarCertificadoWord;
        private Button GenerarCertificadoPDF;
        private Label lblDNI;
        private ComboBox listaDocumentos_ComboBox;
    }
}


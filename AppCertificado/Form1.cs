using DocumentFormat.OpenXml.Packaging;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordToPDF;

namespace AppCertificado
{
    public partial class Form1 : Form
    {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerarCertificado_Click(object sender, EventArgs e)
        {
            try {
                CrearArchivo();
                List<string> parametros = CargarParametros();
                List<string> valores = CargarValores();
                ModificarArchivo(parametros, valores);
                //ConvertirEnPDF();
                MostrarMensaje();
                BlanquearDatos();
            }
            catch (Exception exc) {
                Console.WriteLine(exc.Message);
            }
        }

        private void CrearArchivo()
        {
            File.Copy(@"C:\Program Files (x86)\RoniCorp\AppCertificadoSetup\Certificados\Certificado-Template.docx", path + @"\Certificado_"+txtNombre.Text+"_"+txtApellido.Text+".docx");
        }

        private void ModificarArchivo(List<string> parametros, List<string> valores)
        {
            for (int i = 0; i < parametros.Count; i++) {
                string ruta_archivo = path + @"\Certificado_" + txtNombre.Text + "_" + txtApellido.Text + ".docx";
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ruta_archivo, true))
                    TextReplacer.SearchAndReplace(wordDoc: doc, search: parametros[i], replace: valores[i], matchCase: false);
            }            
        }

        private List<string> CargarParametros()
        {
            List<string> parametros = new List<string>();
            parametros.Add("[NombreCurso]");
            parametros.Add("[Nombre]");
            parametros.Add("[Apellido]");
            parametros.Add("[DNI]");
            parametros.Add("[DescripcionTitulo]");
            return parametros;
        }

        private List<string> CargarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(txtNombreCurso.Text);
            valores.Add(txtNombre.Text);
            valores.Add(txtApellido.Text);
            valores.Add(txtDNI.Text);
            valores.Add(txtDescripcionTitulo.Text);
            return valores;
        }

        private void ConvertirEnPDF()
        {
            Word2Pdf objWorPdf = new Word2Pdf();
            string ruta_archivo = path+@"\";
            string nombre_archivo = "Certificado_" + txtNombre.Text + "_" + txtApellido.Text + ".docx";
            string ruta_completa = ruta_archivo + nombre_archivo;
            string FileExtension = Path.GetExtension(ruta_archivo);
            string ChangeExtension = nombre_archivo.Replace(FileExtension, ".pdf");
            if (FileExtension == ".doc" || FileExtension == ".docx")
            {
                object ToLocation = path + "\\" + ChangeExtension;
                objWorPdf.InputLocation = ruta_completa;
                objWorPdf.OutputLocation = ToLocation;
                objWorPdf.Word2PdfCOnversion();
            }
        }
        private void MostrarMensaje()
        {
            string message = "El archivo fue creado con éxito en la siguiente ruta:\n "+path+ @"\Certificado_" + txtNombre.Text + "_" + txtApellido.Text + ".docx"; ;
            string title = "Aviso!";
            MessageBox.Show(message, title);
        }

        private void BlanquearDatos()
        {
            txtNombreCurso.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDNI.Text = null;
            txtDescripcionTitulo.Text = null;
        }
    }
}

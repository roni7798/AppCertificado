using DocumentFormat.OpenXml.Packaging;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace AppCertificado
{
    public partial class Form1 : Form
    {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string[][] tipoDocumentos;

        public Form1()
        {
            InitializeComponent();
            ObtenerlistaDocumentos_ComboBox();
        }

        private bool chequearDatos()
        {
            if (txtNombreCurso.Text != "" && txtNombreCurso.Text != "" && txtApellido.Text != "" && txtDNI.Text != "" && txtDescripcionTitulo.Text != "" && listaDocumentos_ComboBox.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool GenerarWord()
        {
            if (chequearDatos())
            {
                try
                {
                    CrearArchivo();
                    List<string> parametros = CargarParametros();
                    List<string> valores = CargarValores();
                    ModificarArchivo(parametros, valores);
                    //ConvertirEnPDF();                    
                    return true;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Completar todos los campos vacíos!!!");
                return false;
            }
        }

        private void GenerarCertificadoWord_Click(object sender, EventArgs e)
        {
            if (GenerarWord()) {
                MostrarMensajeWord();
                BlanquearDatos();
            }                       
        }

        private void CrearArchivo()
        {
            File.Copy(@"C:\Program Files (x86)\RoniCorp\Certificados\Certificado-Template.docx", path + @"\Certificado_"+txtNombre.Text+"_"+txtApellido.Text+".docx");
        }

        private void ModificarArchivo(List<string> parametros, List<string> valores)
        {
            string ruta_archivo = path + @"\Certificado_" + txtNombre.Text + "_" + txtApellido.Text + ".docx";
            for (int i = 0; i < parametros.Count; i++) {                
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ruta_archivo, true))
                    TextReplacer.SearchAndReplace(wordDoc: doc, search: parametros[i], replace: valores[i], matchCase: false);
            }
            using (WordprocessingDocument doc = WordprocessingDocument.Open(ruta_archivo, true))
                TextReplacer.SearchAndReplace(wordDoc: doc, search: "DNI", replace: obtenerDocumentoActualizado(), matchCase: false);
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

        private void ObtenerlistaDocumentos_ComboBox()
        {
            tipoDocumentos = new string[][]
            {
                //Tipos de documento de Lationamerica.
                new string[] {"DNI", "Documento nacional de identidad"},
                new string[] {"CC", "Cédula de ciudadanía"},
                new string[] { "CURP Credencial para Votar.", "Clave única de registro de población y Credencial para votar o Credencial de Elector." },
                new string[] { "CI", "Cédula de identidad"},
                new string[] { "DPI", "Documento Personal de Identificación"},
                new string[] { "RG", "Carteira de Identidade o Registro Geral"},
                new string[] { "CIC/CI", "Cédula de identidad Civil" },
                new string[] { "DUI", "Documento único de identidad" },
                new string[] { "CIE", "Cédula de identidad y electoral" },
                new string[] { "CIP", "Cédula de identidad personal" },
                new string[] { "ID", "Licencia de Conducir o Identificación" },
                new string[] { "CI", "Carnet de Identidad" }
            };
            for (int i = 0; i < tipoDocumentos.Length; i++)
            {
                //Console.WriteLine(tipoDocumentos[i][0] + " - " + tipoDocumentos[i][1]);
                listaDocumentos_ComboBox.Items.Add(tipoDocumentos[i][0] + " - " + tipoDocumentos[i][1]);
            }
        }
        private void MostrarMensajeWord()
        {
            string message = "El archivo fue creado con éxito en la siguiente ruta:\n "+path+ @"\Certificado_" + txtNombre.Text + "_" + txtApellido.Text + ".docx"; ;
            string title = "Aviso!";
            MessageBox.Show(message, title);
        }
        private void MostrarMensajePDF()
        {
            string message = "El archivo fue creado con éxito en la siguiente ruta:\n " + path + @"\Certificado_" + txtNombre.Text + "_" + txtApellido.Text + ".PDF"; ;
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
            listaDocumentos_ComboBox.Text = "";
        }
        private string obtenerDocumentoActualizado() 
        {
            char delimitador = '-';
            string[] documentoArray = listaDocumentos_ComboBox.SelectedItem.ToString().Split(delimitador);
            string docuActualizado = documentoArray[0].Trim();
            return docuActualizado;
        }

       
        
        private void GenerarCertificadoPDF_Click(object sender, EventArgs e)
        {
            
        }
    }
}

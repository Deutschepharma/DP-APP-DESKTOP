using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria para generar PDF 
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
//Using para generar Documentos con creacion de estos.
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using Entity;
using Controller;

namespace Utilities
{
    public class Ut_GeneraPDF
    {
        SqlConnection cn = Conexion.getConexion();
        string lblCuaderno, nombre, paterno, materno, nacimiento, direccion, email, autoriza,
                 fono, farmacia, boleta, compra, funcionario, observacion, medico, centro_medico;

        public bool GeneraCuaderno(En_ListasDatos l)
        {
            DateTime hoy = new DateTime();
            //hoy = "dd-MM-yyyy";
            string archivoExiste = "C:\\DP-APP-DESKTOP\\ruta.ini";
            string path;
            FileStream fs_inv = new FileStream(archivoExiste, FileMode.Open);
            StreamReader sr_inv = new StreamReader(fs_inv);
            path = sr_inv.ReadLine();
            sr_inv.Close();
            fs_inv.Close();
            string C = @"" + path + "";

            foreach (En_CuadernoOralne c in l.co)
            {
                lblCuaderno = c.NRO_CUADERNO;
                nombre = c.CLIENTE_NOMBRE;
                paterno = c.CLIENTE_PATERNO;
                materno = c.CLIENTE_MATERNO;
                nacimiento = c.CLIENTE_NACIMIENTO.ToString();
                direccion = c.CLIENTE_DIRECCION;
                email = c.CLIENTE_EMAIL;
                fono = c.CLIENTE_FONO;
                boleta = c.RECETA_NRO_BOLETA.ToString();
                compra = c.RECETA_FECHA_COMPRA.ToString();
                funcionario = c.RECETA_FUNCIONARIO;
                observacion = c.RECETA_OBSERVACION;
                medico = c.PRESCRIPTOR_MEDICO_DESCRIPCION;
                centro_medico = c.PRESCRIPTOR_CENTRO_MEDICO_DESCRIPCION;
                farmacia = c.PRESCRIPTOR_FARMACIA_DESCRIPCION;
                if (c.CLIENTE_AUTORIZA_CONTACTO=='S')
                {
                    autoriza = "SI";
                }
                if (c.CLIENTE_AUTORIZA_CONTACTO == 'N')
                {
                    autoriza = "NO";
                }
            }
            string fileName = C + lblCuaderno + ".pdf";
            Document document = new Document(PageSize.LETTER, 60, 50, 25, 25);
            try
            {
                PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
            }
            catch (Exception)
            {
                throw;
            }
            document.Open();

            string imageURL = "C:\\DP-APP-DESKTOP\\img\\logo-dp-127x28.png";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);
            jpg.ScaleToFit(90f, 40f);
            jpg.SpacingBefore = 10f;
            jpg.SpacingAfter = 1f;
            jpg.Alignment = Element.ALIGN_RIGHT;
            document.Add(jpg);

            Paragraph Titulo = new Paragraph();
            Titulo.Alignment = Element.ALIGN_RIGHT;
            Titulo.Font = FontFactory.GetFont("Console", 10);
            Titulo.Add("Cuaderno N° " + lblCuaderno+"\n");
            Titulo.Add(hoy.Date.ToString());
            document.Add(Titulo);

            Paragraph cliente = new Paragraph();
            cliente.Alignment = Element.ALIGN_LEFT;
            cliente.Font = FontFactory.GetFont("Verdana", 8);
            cliente.Add("NOMBRE                     : " + nombre+" "+paterno+" "+materno + "\n");
            cliente.Add("FECHA NACIMIENTO : " + nacimiento + "\n");
            cliente.Add("DIRECCION                 : " + direccion + "\n");
            cliente.Add("E-MAIL                         : " + email + "\n");
            cliente.Add("TELEFONO                  : " + fono + "\n");
            cliente.Add("MEDICO                       : " + medico + "\n");
            cliente.Add("CENTRO MEDICO       : " + centro_medico + "\n\n\n");
            document.Add(cliente);
            try
            {
                PdfPTable unaTabla = new PdfPTable(4);
                unaTabla.SetWidthPercentage(new float[] { 80, 300, 80, 80 }, PageSize.LETTER);
                unaTabla.AddCell(new Paragraph("CODIGO", FontFactory.GetFont("Console", 7)));
                unaTabla.AddCell(new Paragraph("NOMBRE", FontFactory.GetFont("Console", 7)));
                unaTabla.AddCell(new Paragraph("CANTIDAD", FontFactory.GetFont("Console", 7)));
                unaTabla.AddCell(new Paragraph("VENC / LOTE", FontFactory.GetFont("Console", 7)));
                foreach (PdfPCell celda in unaTabla.Rows[0].GetCells())
                {
                    celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                    celda.HorizontalAlignment = 1;
                    celda.Padding = 3;
                }
                foreach (En_CuadernoOralneProducto p in l.cop)
                {
                    unaTabla.AddCell(new Paragraph("" + p.PRODUCTO_MAESTRO_CODIGO + "", FontFactory.GetFont("Console", 7)));
                    unaTabla.AddCell(new Paragraph("" + p.NOMBRE + "", FontFactory.GetFont("Console", 7)));
                    unaTabla.AddCell(new Paragraph("" + p.LOTE + "", FontFactory.GetFont("Console", 7)));
                    unaTabla.AddCell(new Paragraph("" + p.Cantidad + "\n", FontFactory.GetFont("Console", 7)));
                }
                document.Add(unaTabla);
            }
            catch (Exception)
            {

                throw;
            }
            
            Paragraph datos = new Paragraph();
            datos.Alignment = Element.ALIGN_LEFT;
            datos.Font = FontFactory.GetFont("Verdana", 8);
            datos.Add("\n\nFARMACIA              : " + farmacia + "\n");
            datos.Add("NUMERO BOLETA : " + boleta + "\n");
            datos.Add("FECHA COMPRA   : " + compra + "\n");
            datos.Add("FUNCIONARIO       : " + funcionario + "\n");
            
            datos.Add("OBSERVACIONES : " + observacion+ "\n\n\n\n\n\n\n\n\n\n");
            datos.Add("AUTORIZA CONTACTO CON INFORMACIÓN RELACIONADA AL PRODUCTO : " + autoriza + "             ______________________________");
            document.Add(datos);
            document.Close();

            Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = fileName;
            return prc.Start();
        
        }

    }
}

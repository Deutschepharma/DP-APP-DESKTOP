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

namespace Controller
{
    public class Co_GeneraPDF
    {
        SqlConnection cn = Conexion.getConexion();
        string lblCuaderno, nombre, paterno, materno, nacimiento, direccion, email,
                 fono, farmacia, boleta, compra, funcionario, observacion, medico, centro_medico;

        public bool GeneraCuaderno(ListasDatos l)
        {
            
            string archivoExiste = "C:\\DP-APP-DESKTOP\\ruta.ini";
            string path;
            FileStream fs_inv = new FileStream(archivoExiste, FileMode.Open);
            StreamReader sr_inv = new StreamReader(fs_inv);
            path = sr_inv.ReadLine();
            //Cerrar Objetos
            sr_inv.Close();
            fs_inv.Close();
            //pega
            string C = @"" + path + "";

            //casa
            //string C = "C:\\172.16.1.55\\Sistemas\\RegistrosCuadernoOralne\\";
            


            foreach (CuadernoOralne c in l.co)
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
                medico = c.PRESCRIPTOR_MEDICO;
                centro_medico = c.PRESCRIPTOR_CENTRO_MEDICO;
            }


            string fileName = C + lblCuaderno + ".pdf";
            Document document = new Document(PageSize.LETTER, 60, 50, 25, 25);
            PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));

            document.Open();
            //numero de la orden de compra

            Paragraph Titulo1 = new Paragraph();
            Titulo1.Alignment = Element.ALIGN_LEFT;
            Titulo1.Font = FontFactory.GetFont("Console", 14);
            Titulo1.Add("N°" + lblCuaderno);
            document.Add(Titulo1);

            string imageURL = "C:\\DP-APP-DESKTOP\\img\\logo-dp-127x28.png";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);
            //Resize image depend upon your need
            jpg.ScaleToFit(90f, 40f);
            //Give space before image
            jpg.SpacingBefore = 10f;
            //Give some space after the image
            jpg.SpacingAfter = 1f;
            jpg.Alignment = Element.ALIGN_RIGHT;

            Paragraph Titulo2 = new Paragraph();
            Titulo2.Alignment = Element.ALIGN_LEFT;
            Titulo2.Font = FontFactory.GetFont("Console", 10);
            Titulo2.Add("DEUTSCHEPHARMA S.A");
            document.Add(jpg);

            //Paragraph Cabecera01 = new Paragraph();
            //Cabecera01.Alignment = Element.ALIGN_LEFT;
            //Cabecera01.Font = FontFactory.GetFont("Console", 7);
            //Cabecera01.Add("EMPRESAS DMG S.A.\n");
            //Cabecera01.Add("R.U.T: 96.803.690-4\n");
            //Cabecera01.Add("MEIGGS 58, SANTIAGO  FONO: (562)23962100  FAX: (562) 23962157\n\n");
            //document.Add(Cabecera01);

            Paragraph cliente = new Paragraph();
            cliente.Alignment = Element.ALIGN_LEFT;
            cliente.Font = FontFactory.GetFont("Verdana", 8);
            cliente.Add("NOMBRE       : " + nombre+" "+paterno+" "+materno + "\n");
            cliente.Add("FECHA NACIMIENTO          : " + nacimiento + "\n");
            cliente.Add("DIRECCION                    : " + direccion + "\n");
            cliente.Add("E-MAIL                    : " + email + "\n");
            cliente.Add("TELEFONO                    : " + fono + "\n");
            cliente.Add("MEDICO                    : " + medico + "\n");
            cliente.Add("CENTRO MEDICO                    : " + centro_medico + "\n\n");
            //Proveedor.Add("FONO                    : " + fonoProveedor + "  FAX : " + faxProveedor + "\n");
            //Proveedor.Add("ATENCION            : " + g.atencionProveedor + "        CONDICION DE PAGO : " + g.condicionProveedor + "\n\n");
            document.Add(cliente);

            

            //¿Le damos un poco de formato?
            try
            {
                PdfPTable unaTabla = new PdfPTable(4);
                unaTabla.SetWidthPercentage(new float[] { 80, 300, 80, 80 }, PageSize.LETTER);

                //Headers
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
                foreach (CuadernoOralneProducto p in l.cop)
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
            

            //SqlCommand comando = new SqlCommand("SELECT CANTIDAD, DESCRIPCION, CODIGO, PRECIO_UNIDAD, SUB_TOTAL FROM OC_DETALLE WHERE ID_OC = " + Convert.ToInt32(g.numeroOC) + "", cn);
            //cn.Open();
            //SqlDataReader leer = comando.ExecuteReader();

            //List<CuadernoOralneProducto> listaProductos = new List<CuadernoOralneProducto>();
            //CuadernoOralneProducto prod = new CuadernoOralneProducto();
            
            //while (leer.Read())
            //{
            //    string cantidad = leer["CANTIDAD"].ToString();
            //    string descripcion = leer["DESCRIPCION"].ToString();
            //    string codigo = leer["CODIGO"].ToString();
            //    string preciounidad = leer["PRECIO_UNIDAD"].ToString();
            //    string subtotal = leer["SUB_TOTAL"].ToString();

            //    unaTabla.AddCell(new Paragraph("" + cantidad + "", FontFactory.GetFont("Console", 7)));
            //    unaTabla.AddCell(new Paragraph("" + descripcion + "", FontFactory.GetFont("Console", 7)));
            //    unaTabla.AddCell(new Paragraph("" + codigo + "", FontFactory.GetFont("Console", 7)));
            //    unaTabla.AddCell(new Paragraph("" + preciounidad + "", FontFactory.GetFont("Console", 7)));
            //    unaTabla.AddCell(new Paragraph("" + subtotal + "\n", FontFactory.GetFont("Console", 7)));
            //}
            
            //cn.Close();
            Paragraph datos = new Paragraph();
            datos.Alignment = Element.ALIGN_LEFT;
            datos.Font = FontFactory.GetFont("Verdana", 8);
            datos.Add("FARMACIA       : " + farmacia + "\n");
            datos.Add("FECHA COMPRA          : " + compra + "\n");
            datos.Add("FUNCIONARIO                    : " + funcionario + "\n");
            datos.Add("OBSERVACIONES                    : " + observacion + "\n");
            //Paragraph final = new Paragraph();
            //final.Alignment = Element.ALIGN_RIGHT;
            //final.Font = FontFactory.GetFont("Verdana", 8);
            //final.Add("SUB TOTAL       : " + g.netoOC + "\n");
            //final.Add("DESCUENTO          : " + g.descuentoOC + "\n");
            //final.Add("IVA          : " + g.ivaOC + "\n");
            //final.Add("TOTAL CON IVA          : " + g.totalOC + "\n");
            //document.Add(final);


            //Paragraph nota = new Paragraph();
            //nota.Alignment = Element.ALIGN_LEFT;
            //nota.Font = FontFactory.GetFont("Verdana", 8);
            //nota.Add("AUTORIZA      : " + g.autotizaOC + "\n");
            //nota.Add("NOTA          : " + g.notaOC + "\n");
            //document.Add(nota);

            //terminar y lanzar el pdf
            document.Close();

            //Y para lanzarlo vamos a hacer uso de Process (Que esta en System.Diagnostics)
            Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = fileName;
            return prc.Start();
        }

    }
}

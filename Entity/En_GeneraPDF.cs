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

namespace Entity
{
    public class En_GeneraPDF
    {
        public string rutProveedor { get; set; }
        public string fechaOC { get; set; }
        public string numeroOC { get; set; }
        public string nombreProveedor { get; set; }
        public string direccionProveedor { get; set; }
        public string fonoProveedor { get; set; }
        public string faxProveedor { get; set; }
        public string atencionProveedor { get; set; }
        public string condicionProveedor { get; set; }
        public string netoOC { get; set; }
        public string descuentoOC { get; set; }
        public string ivaOC { get; set; }
        public string totalOC { get; set; }
        public string autotizaOC { get; set; }
        public string notaOC { get; set; }
    }
}

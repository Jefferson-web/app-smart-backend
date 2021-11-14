using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Archivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string archivoId { get; set; }
        public int citaId { get; set; }
        public string nombre { get; set; }
        public byte[] data { get; set; }
        public string content_type { get; set; }
        public long tamano { get; set; }
        public string extension { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}

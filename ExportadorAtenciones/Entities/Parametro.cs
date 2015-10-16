using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorAtenciones.Entities
{
    [Table("tabpar", Schema = "cat")]
    public class Parametro
    {
        [Key]
        [Column("codpar")]
        public String Id { get; set; }

        [Column("nompar")]
        public String Nombre { get; set; }

        [Column("valpar")]
        public String Valor { get; set; }

        [Column("tippar")]
        public String Tipo { get; set; }

        [Column("estpar")]
        public String Estado { get; set; }

        [Column("grupar")]
        [ForeignKey("Grupo")]
        public String GrupoId { get; set; }

        public virtual Parametro Grupo { get; set; }
    }
}

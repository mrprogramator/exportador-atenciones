﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExportadorAtenciones.Entities
{
    [Table("tabusu", Schema = "cat")]
    public class Usuario
    {
        [Key]
        [Column("codusu")]
        public String Id { get; set; }

        [Column("emausu")]
        public String Email { get; set; }

        [Column("clausu")]
        public String Password { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace vertivina.Models
{
    public class Persona{
        public int ID { get; set; }
        public string nombre { get; set; }
        public string telefono{get; set;}
        
    }
}
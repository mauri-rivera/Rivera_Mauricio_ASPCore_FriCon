#pragma warning disable CS8618

using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriCon.Models
{
    public class Mascota
    {
        [Key]
        public int MascotaId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public Tipos Tipo { get; set; }

        [Required]
        public int Edad { get; set; }

        [Required]
        public bool TienePelo { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }

    public enum Tipos
    {
        Perro, Gato, Pájaro
    }
}
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesFimes.Modelo
{
    public class Filme
    {
        public int id { get; set; }
        public string titulo { get; set; } = string.Empty;
        
        [DataType(DataType.Date)]
        public DateTime dataLancamento { get; set; }
        public string genero { get; set; } = string.Empty;
        public decimal preco { get; set; }

    }
}

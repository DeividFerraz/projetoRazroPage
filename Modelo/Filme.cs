using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesFimes.Modelo
{
    public class Filme
    {
        public int id { get; set; }
        [Display(Name = "Titulo")]
        public string titulo { get; set; } = string.Empty;

        [Display(Name ="Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime dataLancamento { get; set; }

        [Display(Name = "Genêro")]
        public string genero { get; set; } = string.Empty;
        [Display(Name = "Preço")]
        public decimal preco { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace BlazorTestes.Models
{
    public class Medico
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Nome é obrigatório")]
        public string Nome { get; set; }
        public string Crm { get; set; }
    }
}

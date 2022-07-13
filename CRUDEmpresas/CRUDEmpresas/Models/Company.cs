
using System.ComponentModel.DataAnnotations;

namespace CRUDEmpresas.Models
{
    public class Company
    {
        
        [Key]

        public Guid Id { get; set; }

        [Required]  
        [MaxLength(100)]    
        public string Nome { get; set; }

        [Required]
        [MaxLength(14)]
        public string Contacto { get; set; }


        public void GenerateNewId()
        {
            Id = Guid.NewGuid();
        }
    }
}

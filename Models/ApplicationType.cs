using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_MVC_Basic.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

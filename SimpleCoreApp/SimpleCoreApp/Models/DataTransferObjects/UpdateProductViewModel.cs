using System.ComponentModel.DataAnnotations;

namespace SimpleCoreApp.Models.DataTransferObjects
{
    public class UpdateProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public decimal? Price { get; set; }

        public int? CategoryId { get; set; }
    }
}

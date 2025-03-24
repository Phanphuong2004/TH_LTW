using PhanDangPhuong_2280602529.Models;
using System.ComponentModel.DataAnnotations;

namespace PhanDangPhuong_2280602529.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}

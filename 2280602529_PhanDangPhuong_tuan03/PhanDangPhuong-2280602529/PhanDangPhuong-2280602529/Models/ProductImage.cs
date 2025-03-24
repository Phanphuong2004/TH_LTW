using PhanDangPhuong_2280602529.Models;
using System.ComponentModel.DataAnnotations;

namespace PhanDangPhuong_2280602529.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}

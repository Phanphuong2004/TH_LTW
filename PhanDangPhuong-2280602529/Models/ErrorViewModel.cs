using System.ComponentModel.DataAnnotations;

namespace PhanDangPhuong_2280602529.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

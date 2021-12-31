using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Models
{
    
    public class ProductType
    {
        [Key]
        [DisplayName("Mã Loại")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "{0} từ 6-100 kí tự")]
        [DisplayName("Tên đăng nhập")]
        public string Name { get; set; }

        [DisplayName("Trạng thái tài khoản")]
        public int Status { get; set; }
    }
}

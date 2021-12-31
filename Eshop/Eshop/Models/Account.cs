using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class Account
    {
        [Key]
        [DisplayName("Mã tài khoản")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} từ 6-20 kí tự")]
        [DisplayName("Tên đăng nhập")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} từ 6-20 kí tự")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [RegularExpression(@"(\W|^)[\w.+\-]*@gmail\.com(\W|$)", ErrorMessage = "{0} phải có gmail")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Address { get; set; }

        [DisplayName("Tên đầy đủ")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Fullname { get; set; }

        [DisplayName("Quyền quản trị viên")]
        public bool IsAdmin { get; set; }

        [DisplayName("Tên ảnh đại diện")]
        public string Avatar { get; set; }

        [DisplayName("Trạng thái tài khoản")]
        public int Status { get; set; }

        //public List<Order> Orders { get; set; }
        //public List<Cart> Carts { get; set; }
    }
}

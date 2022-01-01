using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class Cart
    {
        [Key]
        [DisplayName("Mã Loại")]
        public int Id { get; set; }

     
        [DisplayName("Mã Tài khoản")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

        [DisplayName("Mã Sản phẩm")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}

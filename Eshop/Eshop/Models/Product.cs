using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class Product
    {
        [Key]
        [DisplayName("Mã SP tự tăng")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DisplayName("Mã SP")]
        public string SKU { get; set; }

   
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DisplayName("Tên SP")]
        public string Name { get; set; }


        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DisplayName("Price")]
        public int Phone { get; set; }

        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public int Stock { get; set; }

        [DisplayName("Mã loại")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        [DisplayName("Ảnh")]
        public string Image { get; set; }


        [DisplayName("Trạng thái ")]
        public int Status { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public List<Cart> Carts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiaiptBac1.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public string KhachHangID { get; set; }
        public string KhachHangName { get; set; }
        public string Address { get; set; }
    }
}
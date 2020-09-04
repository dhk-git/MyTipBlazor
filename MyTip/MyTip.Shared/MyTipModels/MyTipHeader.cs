using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTip.Shared.MyTipModels
{
    public class MyTipHeader
    {
        [Key]
        public int TipHeaderID { get; set; }
        public string TipTitle { get; set; }
        public DateTime InsertDttm { get; set; }
        public DateTime UpdateDttm { get; set; }
    }
}

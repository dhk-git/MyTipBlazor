using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTip.Shared.MyTipModels
{
    public class MyTipDetail
    {
        [Key]
        public int TipDetailID { get; set; }
        public MyTipHeader MyTipHeader { get; set; }
        public string TipContent { get; set; }
        public DateTime InsertDttm { get; set; }
        public DateTime UpdateDttm { get; set; }

    }
}

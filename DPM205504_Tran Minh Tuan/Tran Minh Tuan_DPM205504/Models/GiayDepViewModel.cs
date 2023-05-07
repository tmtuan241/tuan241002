using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace DPM205488_LMT.Models
{
    public class GiayDepViewModel
    {
        public GiayDepViewModel()
        {
        }
        public int MaGiay { get; set; }
        public string TenGiay { get; set; }
        public int SizeGiay { get; set; }
    }

}

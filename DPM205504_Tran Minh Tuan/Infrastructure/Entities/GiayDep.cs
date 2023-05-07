using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    [Table("GiayDep")]
    public class GiayDep
    {
        [Key]
        public int MaGiay { get; set; }
        public string TenGiay { get; set; }
        public int SizeGiay { get; set; }
     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace UpsideDownOperators.Orm.Entity
{
    public class UserProperty : BaseEntity
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string TelefonNo { get; set; }
        [Required]
        public string TC { get; set; }
        [Required]
        public string Sifre { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Gorev { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string IseGırısTarihi { get; set; }
        [Required]
        public string MaasTipi { get; set; }
        public string Vesikalık { get; set; }
        List<ExecutiveProperty> ExecutivePropertys = new List<ExecutiveProperty>();
    }
}

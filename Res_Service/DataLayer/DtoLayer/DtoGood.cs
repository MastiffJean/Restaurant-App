using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DtoLayer
{
    [DataContract]
    public class DtoGood
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Image { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public int Category_Id { get; set; }
    }
}

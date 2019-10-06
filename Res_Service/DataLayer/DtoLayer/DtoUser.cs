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
    public class DtoUser
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
        public string Login { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [DataMember]
        public int Role_Id { get; set; }
    }
}

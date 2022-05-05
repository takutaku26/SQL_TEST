using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChat.Model
{
    [Table(Name = "PUBLIC_RELATIONS_TBL")]
    class PublicRelationsInformation
    {
        [Column(Name = "ID", IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column(Name = "NAME")]
        public String Name { get; set; }
        [Column(Name = "GENDER")]
        public String Gender { get; set; }
        [Column(Name = "age")]
        public int Age { get; set; }
        [Column(Name = "COURSE")]
        public String Course { get; set; }
    }
}

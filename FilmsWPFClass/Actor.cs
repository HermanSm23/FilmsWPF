using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FilmsWPFClass
{
    [Serializable]
    [DataContract]
    public class Actor : Person
    {
        [DataMember]
        public int Role { get; set; }
        public Actor(string full_name, int sex, DateTime birth, int role) : base(full_name, sex, birth)
        {
            Role = role;
        }
    }
}

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
    public class Employee : Person
    {
        [DataMember]
        public string Position { get; set; }
        public Employee(string full_name, int sex, DateTime birth, string position) : base(full_name, sex, birth)
        {
            Position = position;
        }
    }
}

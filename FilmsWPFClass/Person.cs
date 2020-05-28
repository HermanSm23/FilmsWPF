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
    public class Person
    {
        [DataMember]
        public string Full_name { get; set; }
        [DataMember]
        public int Sex { get; set; }
        [DataMember]
        public DateTime Birth { get; set; }

        public static List<Actor> actors = new List<Actor>();
        public static List<Employee> employees = new List<Employee>();
        public Person(string full_name, int sex, DateTime birth)
        {
            Full_name = full_name;
            Sex = sex;
            Birth = birth;
        }
    }
}

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
    public class Scene
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Period_of_Time { get; set; }
        [DataMember]
        public string Genre { get; set; }
        [DataMember]
        public Actor Actor { get; private set; }
        [DataMember]
        public Employee Employee { get; private set; }
        public static List<Scene> scenes = new List<Scene>();
        public Scene(string name, string location, string period_of_time, string genre, Actor actor, Employee employee)
        {
            Name = name;
            Location = location;
            Period_of_Time = period_of_time;
            Genre = genre;
            Actor = actor;
            Employee = employee;
        }
    }
}

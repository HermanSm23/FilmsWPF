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
    public class Film
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public uint Duration { get; set; }
        [DataMember]
        public DateTime Start_date_shoot { get; set; }
        [DataMember]
        public DateTime End_date_shoot { get; set; }
        [DataMember]
        public DateTime Premier { get; set; }
        [DataMember]
        public uint Budget { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Genre { get; set; }
        [DataMember]
        public Actor Actor { get; private set; }
        [DataMember]
        public Employee Employee { get; private set; }
        [DataMember]
        public Scene Scene { get; private set; }

        public static List<Film> Films = new List<Film>();
        public Film (string name, uint duration, DateTime start_data, DateTime end_date, DateTime premier, 
            uint budget, string description, string genre, Actor actor, Employee employee, Scene scene)
        {
            Name = name;
            Duration = duration;
            Start_date_shoot = start_data;
            End_date_shoot = end_date;
            Premier = premier;
            Budget = budget;
            Description = description;
            Genre = genre;
            Actor = actor;
            Employee = employee;
            Scene = scene;
        }
    }
}

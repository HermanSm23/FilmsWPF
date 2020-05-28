using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FilmsWPFClass
{
    public class FillComboBoxActor
    {
        public FillComboBoxActor(ComboBox listBox, List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                listBox.Items.Add(actor.Full_name);
            }
        }
    }

    public class FillComboBoxEmployee
    {
        public FillComboBoxEmployee(ComboBox listBox, List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                listBox.Items.Add(employee.Full_name);
            }
        }
    }

    public class FillComboBoxScene
    {
        public FillComboBoxScene(ComboBox listBox, List<Scene> scenes)
        {
            foreach (Scene scene in scenes)
            {
                listBox.Items.Add(scene.Name);
            }
        }
    }

    public class FillComboBoxFilm
    {
        public FillComboBoxFilm(ComboBox listBox, List<Film> films)
        {
            foreach (Film film in films)
            {
                listBox.Items.Add(film.Name);
            }
        }
    }
}

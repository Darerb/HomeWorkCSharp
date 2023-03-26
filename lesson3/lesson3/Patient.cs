using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public class Patient
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public bool Status { get; set; }

        public Patient (string patient_name, int patient_age, bool patient_status)
        {
            Name = patient_name;
            Age = patient_age;
            Status = patient_status;

        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Статус: {Status}");
        }

        public virtual void ThankYou()
        {
            if (Status == true)
            {
                Console.WriteLine("Спасибо");
            }
            else
            {
                Console.WriteLine("Пойду к другому врачу :с");
            }
        }


    }
}

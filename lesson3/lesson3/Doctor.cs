using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public class Doctor
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Education { get; set; }

        public Doctor (string doctor_name, int doctor_experience, string doctor_education)
        {
            Name = doctor_name;
            Experience = doctor_experience;
            Education = doctor_education;
        }


        public virtual void DisplayInfo ()
        {
            Console.WriteLine($"Имя: {Name}, Опыт: {Experience}, Образование: {Education}");
        }
        

        public virtual void Care (Patient patient)
        {
            if (patient.Status == false && Experience >= 2)
            {
                patient.Status = true;
                Console.WriteLine("Сейчас полечим");
            }
            if (patient.Status == false && Experience < 2)
            {
                Console.WriteLine("Не знаю, как помочь :с");
            }
            else
            {
                Console.WriteLine("Пациент здоров");
            }
        }
    }
}

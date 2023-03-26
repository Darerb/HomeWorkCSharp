using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public class Ophthalmologist : Doctor
    {
        public string Speciality { get; set; }
        public Ophthalmologist (string doctor_name, int doctor_experience, string doctor_education) : base (doctor_name, doctor_experience, doctor_education)
        {
            Speciality = "ophthalmologist";
            Name = doctor_name;
            Experience = doctor_experience;
            Education = doctor_education;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Специальность: офтальмолог, Имя: {Name}, Опыт: {Experience}, Образование: {Education}");
        }
        public override void Care(Patient patient)
        {
            if (patient.Status == false && Experience >= 4)
            {
                patient.Status = true;
                Console.WriteLine("Сейчас полечим ваши глаза");
            }
            if (patient.Status == false && Experience < 4)
            {
                Console.WriteLine("Не знаю, как помочь вашим глазам :с");
            }
            else
            {
                Console.WriteLine("Со зрением все в порядке");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public class Therapist : Doctor
    {
        public string Speciality { get; set; }
        public Therapist (string doctor_name, int doctor_experience, string doctor_education) : base(doctor_name, doctor_experience, doctor_education)
        {
            Speciality = "therapist";
            Name = doctor_name;
            Experience = doctor_experience;
            Education = doctor_education;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Специальность: терапевт, Имя: {Name}, Опыт: {Experience}, Образование: {Education}");
        }
        public override void Care(Patient patient)
        {
            if (patient.Status == false && Experience >= 1)
            {
                patient.Status = true;
                Console.WriteLine("Сейчас полечим ваш кашель");
            }
            if (patient.Status == false && Experience < 1)
            {
                Console.WriteLine("Не знаю, как помочь с кашлем :с");
            }
            else
            {
                Console.WriteLine("Пациент не кашляет");
            }
        }
    }
}


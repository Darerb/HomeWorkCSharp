using System;

namespace lesson3;
public static class Program
{
    public static void Main()
    {
        //Therapist ther = new Therapist("Елена Львовна", 1, "СибГМУ");
        //ther.DisplayInfo();
        

        //Patient p1 = new Patient("Бабуля", 80, false);
        //p1.DisplayInfo();

        //ther.Care(p1);
        //p1.DisplayInfo();
        //p1.ThankYou();


        Ophthalmologist oph = new Ophthalmologist("Надежда Петровна", 3, "СибГМУ");
        oph.DisplayInfo();

        Patient p2 = new Patient("Дедуля", 85, false);
        p2.DisplayInfo();

        oph.Care(p2);
        p2.DisplayInfo();
        p2.ThankYou();

    }
}

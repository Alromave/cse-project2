using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job ();
        job1._company = "El Escudo";
        job1._jobTitle = "Coordinator";
        job1._starYear = 1982;
        job1._endYear = 1984;

        Job job2 = new Job();
        job2._company = "Banco de Guatemala";
        job2._jobTitle = "Analist";
        job2._starYear = 1984;
        job2._endYear = 1994;
        
        //Console.WriteLine(" the first company is " + job1._company);
        //Console.WriteLine("the second company is:" + job2._company);

        Resume myResume = new Resume();
        myResume._name = "Alvaro Maldonado";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }

}


        
    
            
        


    

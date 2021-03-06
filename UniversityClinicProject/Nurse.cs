﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Nurse : Employee

    {
        //new object
        Patient newPatient = new Patient();

        //Properties
        int NumOfPatients { get; set; }
       
        //Constructor
        public Nurse() : base()
        {
        
        }

        public Nurse(string name, int iDNumber, int numOfPatients) : base(name, iDNumber)
        {
            NumOfPatients = numOfPatients;
            Salary = 50000;
            Name = name;
            IDNumber = iDNumber;
            Paid = false;
        }

        //Methods
        public override void DisplayInfo()
        {
            Console.WriteLine($"\n2. {Name} | ID Number: {IDNumber} | Salary: ${Salary} | # of Patients: {NumOfPatients}");
        }
        
        public override void DrawBlood(Patient newPatient)
        {
            newPatient.BloodLevel -= 1;
            Console.WriteLine($"{Name} has successfully drawn blood. The new blood level is {newPatient.BloodLevel}");
        }


        public override void CareForPatient(Patient newPatient)
        {
            newPatient.HealthStatus += 1;
            Console.WriteLine($"{Name} has successfully cared for the patient. The new health status is {newPatient.HealthStatus}");
        }

        public override void PaySalary()
        {
            if (Paid == false)
            { Console.WriteLine($"Nurse {Name} has been paid");
                Paid = true;
            }
            else
            {Console.WriteLine($"Nurse {Name} has already been paid");}
        }

    }
}

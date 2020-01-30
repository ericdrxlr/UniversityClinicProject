﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Employee
    {
        //Properties
        public string Name { get; set; }
        public int IDNumber { get; set; }
        public virtual int Salary { get; set; }
        public bool Paid { get; set; }

        //Constructors
        public Employee()
        { 
        }

        public Employee(string name, int iDNumber)
        {
            Name = name;
            IDNumber = iDNumber;
        }

        //Methods
        public void HasBeenPaid()
        {
            if (Paid == true)
            { Console.WriteLine("The Employee has been paid"); }
            else
            { Console.WriteLine("The Employee has not been paid"); }
        }
    }
}        
             

       




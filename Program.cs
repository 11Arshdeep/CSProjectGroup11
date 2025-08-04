// COMP2104 – Data Centre Technologies
// Patient Health Tracker Project
// Submitted by: Student Name / Group X
// Instructor: Anmar Jarjees
// Description: Calculates blood pressure range and BMI for a patient using OOP




using System;

namespace CSProjectGroupX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Patient Health Tracker!");

            // Collect user data
            Console.Write("Enter First Name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lName = Console.ReadLine();

            Console.Write("Enter Weight in KG: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Height in CM: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter SYSTOLIC BP (Upper number): ");
            int systolic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter DIASTOLIC BP (Lower number): ");
            int diastolic = Convert.ToInt32(Console.ReadLine());

            // Create patient object
            Patient myPatient = new Patient(fName, lName, weight, height);

            // Show patient report
            myPatient.PrintPatientInfo(systolic, diastolic);

            Console.WriteLine("Thank you for using our system. Stay healthy!");
        }
    }
}

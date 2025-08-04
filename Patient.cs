// COMP2104 – Data Centre Technologies
// Patient Health Tracker Project
// Submitted by: Student Name / Group X
// Instructor: Anmar Jarjees
// Description: Calculates blood pressure range and BMI for a patient using OOP

using System;

namespace CSProjectGroupX
{
    public class Patient
    {
        // 1. Private fields
        private string firstName;
        private string lastName;
        private double weight; // in KG
        private double height; // in CM

        // 2. Public Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // 3. Constructor
        public Patient(string firstName, string lastName, double weight, double height)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weight = weight;
            this.height = height;
        }

        // 4. Blood Pressure Checker (Public)
        public string CheckBloodPressure(int systolic, int diastolic)
        {
            if (systolic < 120 && diastolic < 80)
                return "NORMAL";
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
                return "ELEVATED";
            else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            else if ((systolic >= 140 && systolic <= 180) || (diastolic >= 90 && diastolic <= 120))
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            else if (systolic > 180 || diastolic > 120)
                return "HYPERTENSIVE CRISIS (Consult your doctor immediately)";
            else
                return "Invalid blood pressure values.";
        }

        // 5. BMI Calculator (Private)
        private double CalculateBMI()
        {
            double heightInMeters = height / 100.0;
            return weight / (heightInMeters * heightInMeters);
        }

        // 6. Patient Info Printer (Public)
        public void PrintPatientInfo(int systolic, int diastolic)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Patient Name: {firstName} {lastName}");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Height: {height} cm");

            string bpStatus = CheckBloodPressure(systolic, diastolic);
            Console.WriteLine($"Blood Pressure: {systolic}/{diastolic} mm Hg - {bpStatus}");

            double bmi = CalculateBMI();
            Console.WriteLine($"BMI: {Math.Round(bmi, 2)}");

            if (bmi >= 25)
                Console.WriteLine("BMI Status: Overweight");
            else if (bmi >= 18.5)
                Console.WriteLine("BMI Status: Normal (Healthy Range)");
            else
                Console.WriteLine("BMI Status: Underweight");

            Console.WriteLine("=================================");
        }
    }
}

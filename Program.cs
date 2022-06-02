using System;

namespace Lab1_Task1
{

    // Main Class

    public class Task1_Vehicle
    {
        static void Main(string[] args)
        {
            //Step2 Create few classes and printout field values
            Vehicle vehicle1 = new Vehicle(60,45,"Delta",456);
            Vehicle vehicle2 = new Vehicle(100, 60, "Beta", 457);
            Vehicle vehicle3 = new Vehicle(75, 35, "Gamma", 458);
            Console.WriteLine("========= Test Case - Print Class Field values ======");
            vehicle1.Test1();
            vehicle2.Test1();
            vehicle3.Test1();

            //Step 3 - No argument and owner name constructor test
            Vehicle vehicle4 = new Vehicle();
            Vehicle vehicle5 = new Vehicle("Shadsa");
            Console.WriteLine("");
            Console.WriteLine("========= Test Case - No argument and owner name constructor ======");
            vehicle4.Test1();
            vehicle5.Test1();

            //Step 5 - change speed & Stop test case
            vehicle1.changeSpeed(90);
            Console.WriteLine("");
            Console.WriteLine("========= Test Case - Change Speed of vehicle1 (ID 456) ======");
            vehicle1.Test1();

            vehicle2.Stop();
            Console.WriteLine("");
            Console.WriteLine("========= Test Case - Stop vehicle2 (ID 457) ======");
            vehicle2.Test1();

            //Step 6 - Turn by degree or constant (right or left)
            vehicle3.Turn(50);
            vehicle4.Turn("right");
            Console.WriteLine("");
            Console.WriteLine("========= Test Case - Turn by degree vehicle3 (ID 458) ======");
            vehicle3.Test1();
            Console.WriteLine("");
            Console.WriteLine("========= Test Case - Turn by right direction vehicle4 ======");
            vehicle4.Test1();
        }

        //simple Vehicle class that has fields for current speed, current direction, owner name
        //

        public class Vehicle
        {
            private double CurrentSpeed;
            private int CurrentDirection;
            private string OwnerName;
            //Step7 - Define Constant
            const string RIGHT = "right";
            const string LEFT = "left";

            //Step1
            //static field for the Vehicle Identification Number
            //non-static field that holds each vehicle’s ID number
            private static string IdentificationNumber = "NZ123";
            private int IDNumber;


            //Step 2
            // Test to prints out vehicle class objects field values

            public Vehicle(double currentSpeed, int currentDirection, string ownerName, int idNumber)
            {
                this.CurrentSpeed = currentSpeed;
                this.CurrentDirection = currentDirection;
                this.OwnerName = ownerName;
                this.IDNumber = idNumber;
            }

            //Test Case Step 1 & 2
            public void Test1()
            {
                Console.WriteLine("Name: " + OwnerName + "\tID Number: " + IDNumber + "\tDirection (degrees): " + CurrentDirection + "\tSpeed: " + CurrentSpeed + "\tIdentification Number: " + IdentificationNumber);
            }

            //Step3
            //no-argument constructor
            public Vehicle() { }

            //constructor that takes an initial owner’s name
            public Vehicle(string ownerName)
            {
                this.OwnerName = ownerName;
            }

            //Step 4 - Properties
            // current speed, current direction & Owner Name have set property
            // Identification Number & ID number should not have set properties
            public double currentSpeed
            {
                get { return CurrentSpeed; }
                //set { CurrentSpeed = value; } // step 5 using the method to change this
            }

            public int currentDirection
            {
                get { return CurrentDirection; }
                set { CurrentDirection = value; }
            }
            public string ownerName
            {
                get { return OwnerName; }
                set { OwnerName = value; }
            }
            public string identificationNumber
            {
                get { return IdentificationNumber; }
            }
            
            public int idNumber
            {
                get { return IDNumber; }
            }


            //Step 5
            //changeSpeed method that changes the current speed of the vehicle to a passed-in value
            //stop method that sets the speed to zero
            public void changeSpeed(double speed)
            {
                this.CurrentSpeed = speed;
            }

            public void Stop()
            {
                this.CurrentSpeed = 0;
            }

            //Step 6
            //Method to takes a number of degrees to turn (180 deg)
            //Method takes Vehicle.TURN LEFT or Vehicle.TURN RIGHT constant
            public void Turn(int degrees)
            {
                CurrentDirection += degrees;
            }

            public void Turn(string direction)
            {
                if (direction == RIGHT)
                {
                    CurrentDirection += 180;
                }
                else
                {
                    CurrentDirection -= 180;
                }
            }

        }
    }
}

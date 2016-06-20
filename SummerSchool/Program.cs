using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] Students = new string[15];

        static void Main(string[] args)
        {
            while (true)
            {
                // TODO: print out the menu
                int choice = Convert.ToInt32(Console.ReadLine());

                // switch alternative:
                //switch (choice)
                //{
                //    case 1:
                //        EnrollStudent();
                //        break;
                //    case 2:
                //        UnenrollStudent();
                //        break;
                //    case 3:
                //        PrintStudents();
                //        break;
                //    default:
                //        Console.WriteLine("Please choose 1-3");
                //        break;
                //}
                if (choice == 1)
                {
                    EnrollStudent();
                }
                else if (choice == 2)
                {
                    UnenrollStudent();
                }
                else if (choice == 3)
                {
                    PrintStudents();
                }
                else if (choice == 4)
                {
                    // quit
                    break;
                }
                else
                {
                    // unknown choice!
                    Console.WriteLine("Please enter a number 1-4");
                }
            }


            Console.ReadKey();
        }

        private static void UnenrollStudent()
        {
        }

        static int GetNextAvailableSpot()
        {
            // to find next available spot:
            // loop over slots until we see null
            /*
             * [0]: "Harry Potter"
             * [1]: "Hermione Granger"
             * [2]: "Neville Longbottom"
             * [3]: null
             * ...
             * [14]: null
             */
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null)
                {
                    // we found one!
                    return i;
                }
            }
            // if we get through the whole list without returning,
            // that means the list is full
            return -1;
        }

        static void EnrollStudent()
        {
            Console.WriteLine("What's the name of the student to enroll?");
            string student = Console.ReadLine();

            // put student in next available spot in Students
            int spot = GetNextAvailableSpot();

            Students[spot] = student;
        }


        static void PrintStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students);
            }
        }

    }
}

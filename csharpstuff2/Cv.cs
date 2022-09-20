using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstuff2
{
    internal class Cv
    {
            private string name;

            public void setName(string name)
            {
                this.name = name;
            }

            public string getName()
            {
                return name;
            }

            public virtual void myInfo()
            {
                Console.WriteLine("A professional who is charged with designing and coding software for businesses and consumers alike. Work closely with clients to determine what they need, uses programming languages like C# and Java to create programs.\n");
            }

            public void mainMenu()
            {
                Console.WriteLine("***** MAIN MENU *****");
                Console.WriteLine("1. Experience/Job");
                Console.WriteLine("2. Education/Training");
                Console.WriteLine("3. Exit Program");
            }

            public void mainMenu(int choice)
            {

                if (choice == 1)
                {
                    Console.WriteLine("***** EXPERIENCE/JOB SUB MENU *****");
                    Console.WriteLine("1. Ceridian (2022 - Current)");
                    Console.WriteLine("2. GO BACK TO MAIN MENU(clear console)");
                }
                else
                {
                    Console.WriteLine("***** EDUCATION/TRAINING SUB MENU *****");
                    Console.WriteLine("1. Year 1 Info");
                    Console.WriteLine("2. Year 2 Info");
                    Console.WriteLine("3. GO BACK TO MAIN MENU(clear console)");
                }
            }

        }

        internal class SubInfo : Cv
        {
            private int choice;
            private int choice2;

            public void setChoice(int choice)
            {
                this.choice = choice;
            }

            public int getChoice()
            {
                return choice;
            }

            public void setChoice2(int choice2)
            {
                this.choice2 = choice2;
            }

            public int getChoice2()
            {
                return choice2;
            }

            public override void myInfo()
            {
                if (getChoice() == 1 && getChoice2() == 1) //Ceridian Info
                {
                    Console.WriteLine("Currently intern at Ceridian Mauritius as part of the Year 2 S.E UOM Industrial Training module. Ungoing JEDI Training in C#, SQL, and Web.\n");
                }
                else if (getChoice() == 2 && getChoice2() == 1) // Year 1 Info
                {
                    Console.WriteLine("Modules such as Database, Discrete Structures, Programming and SE Principles. Projects and Training done include Game Dev and Python Training.\n");
                }
                else // Year 2 Info
                {
                    Console.WriteLine("Modules such as SVV, SPM, Algorithms, OOP. Projects and Training include Mobile Dev and Flutter Training.\n");

                }
            }
        }

        internal class MainProgram
        {
            static void Main(string[] args)
            {

                Cv cv = new Cv();
                cv.setName("Vikesh Sookna");

                Console.WriteLine($"Name : {cv.getName()}");
                cv.myInfo();

                SubInfo sub = new SubInfo();
                bool check = true;
                int choice2;

                while (check)
                {

                    cv.mainMenu();
                    Console.Write("Enter choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    sub.setChoice(choice);
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1: //  Experience/Job
                            cv.mainMenu(choice);
                            Console.Write("Enter choice : ");
                            choice2 = Convert.ToInt32(Console.ReadLine());

                            if (choice2 == 1) // Ceridian (2022-Current)
                            {
                                sub.setChoice2(choice2);
                                sub.myInfo();
                                break;

                            }
                            else if (choice2 == 2) //GO BACK
                            {
                                Console.Clear();
                                break;
                            }
                            else // invalid option
                            {
                                Console.WriteLine("Please select an appropriate option.\n");
                                break;
                            }


                        case 2: // Education/Training
                            cv.mainMenu(choice);
                            Console.Write("Enter choice : ");
                            choice2 = Convert.ToInt32(Console.ReadLine());

                            if (choice2 == 1) // Year 1 Info
                            {
                                sub.setChoice2(choice2);
                                sub.myInfo();
                                break;
                            }
                            else if (choice2 == 2) // Year 2 Info
                            {
                                sub.setChoice2(choice2);
                                sub.myInfo();
                                break;

                            }
                            else if (choice2 == 3) // GO BACK
                            {
                                Console.Clear();
                                break;
                            }
                            else //invalid option
                            {
                                Console.WriteLine("Please select an appropriate option.\n");
                                break;
                            }

                        case 3: //Exit Program
                            check = false;
                            break;

                        default: //Invalid option
                            Console.WriteLine("Please select an appropriate option.\n");
                            break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Program Exited.");
                Console.WriteLine("testing");
                Console.ReadKey();
            }

        }
 }


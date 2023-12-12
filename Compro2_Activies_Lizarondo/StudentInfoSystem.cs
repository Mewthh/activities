using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compro2_Activies_Lizarondo
{
    class StudentInfoSystem
    {
        List<List<String>> Students1 = new List<List<String>>();
        public void MainList()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║           Main Menu                    ║");
                Console.WriteLine("╠════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Add Student                         ║");
                Console.WriteLine("║ 2. Update Student                      ║");
                Console.WriteLine("║ 3. Search Student                      ║");
                Console.WriteLine("║ 4. Delete Student                      ║");
                Console.WriteLine("║ 5. Display Student                     ║");
                Console.WriteLine("║ 6. DemoList                            ║");
                Console.WriteLine("║ 7. Exit                                ║");
                Console.WriteLine("╠════════════════════════════════════════╣");
                Console.WriteLine("║ Choose an option:                      ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)//jackowl
                {
                    case 1:
                        AddStudents();
                        break;
                    case 2:
                        UpdateStudents();
                        break;
                    case 3:
                        SearchStudents();
                        break;
                    case 4:
                        DeleteStudents();
                        break;
                    case 5:
                        DisplayStudents();
                        break;
                    case 6:
                        DemoList();
                        break;
                    case 7:
                        Console.WriteLine();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option.");
                        Console.ResetColor();
                        break;
                }
            }
        }
        private void DemoList()
        {
            //Creating a list
            var numbers2 = new List<int>() { 1, 2, 3, 4, 2 };

            foreach (var number in numbers2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            for (int i = 0; i < numbers2.Count; i++)
            {
                Console.WriteLine(numbers2[i]);
                if (numbers2.Contains(2))
                {
                    numbers2.Remove(2);
                }
            }
        }
        private void Confirm()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Continue?[Y][N]");
            Console.ResetColor();
            string yes = Console.ReadLine();
            Console.Clear();
            Console.WriteLine();

            if (yes == "Y".ToLower())
            {
                AddStudents();
            }
            else if (yes == "N".ToLower())
            {
                MainList();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID INPUT");
                Console.ResetColor();
                Confirm();
            }
            Console.WriteLine();

        }
        private void AddStudents()
        {
            while (true)
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("Enter student number");
                Console.WriteLine("23-24-"); Console.ResetColor();
                string no = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter student full name: ");
                Console.ResetColor();
                string name = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter student program: ");
                Console.ResetColor();
                string program = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter student year: ");
                Console.ResetColor();
                string year = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter student email: ");
                Console.ResetColor();
                string email = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter student address: ");
                Console.ResetColor();
                string address = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter student mobile number: ");
                Console.ResetColor();
                string mobile = Console.ReadLine();
                

                Students1.Add(new List<string> {no, name, program, year, email, address, mobile});
                

                Confirm();
            }
        }
        private void UpdateStudents()
        {
            DisplayStudents();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Enter student name to update: ");
            Console.ResetColor();
            string StudentNameToUpdate = Console.ReadLine();
            //JCxAya
            int updateChoice;
            for (int i = 0; i < Students1.Count; i++)
            {
                if (Students1[i].Contains(StudentNameToUpdate))
                {
                    UpdateMenu();
                    if (int.TryParse(Console.ReadLine(), out updateChoice))
                    {
                        switch (updateChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter new student number: ");
                                Console.WriteLine("23-24-");  Students1[i][0] = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter new student program: ");
                                Students1[i][2] = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter new student year: ");
                                Students1[i][3] = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter new student email: ");
                                Students1[i][4] = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter new student address: ");
                                Students1[i][5] = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter new student mobile number: ");
                                Students1[i][6] = Console.ReadLine();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid option.");
                                Console.ResetColor();
                                break;
                        }
                        Console.Clear();
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("Student information updated successfully!");
                        Console.ResetColor();

                        
                    }
                }
            }
        }
        private void SearchStudents()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Enter the name of the student: ");
            Console.ResetColor();
            string searchName = Console.ReadLine();

            bool found = false;

            foreach (var student in Students1)
            {
                if (student[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Student {searchName} found in list");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Student {searchName} not found in list");
            }
            Console.ResetColor();
        }
        private void DeleteStudents()
        {
            DisplayStudents();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Enter the name of the student to delete: ");
            Console.ResetColor();
            string inputName = Console.ReadLine();

            for (int i = 0; i < Students1.Count; i++)
            {
                if (Students1[i][1].Equals(inputName, StringComparison.OrdinalIgnoreCase))
                {
                    Students1.RemoveAt(i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{inputName} was successfully removed");
                    Console.ResetColor();
                    return;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student {inputName} not found");
            Console.ResetColor();
        }
        private void DisplayStudents()//KONO DIO DA
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===================");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Students in list");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===================");
            Console.ResetColor();

            foreach (var student in Students1)
            {
                Console.WriteLine($"Student: 23-24-{string.Join(", ", student)}");
            }
        }
        private void UpdateMenu()
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║    Choose the information to update:   ║");
            Console.WriteLine("╠════════════════════════════════════════╣");
            Console.WriteLine("║ 1. Student Number                      ║");
            Console.WriteLine("║ 2. Program                             ║");
            Console.WriteLine("║ 3. Year                                ║");
            Console.WriteLine("║ 4. Email                               ║");
            Console.WriteLine("║ 5. Address                             ║");
            Console.WriteLine("║ 6. Mobile Number                       ║");
            Console.WriteLine("╠════════════════════════════════════════╣");
            Console.WriteLine("║ Choose an option:                      ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
        }
    }
}

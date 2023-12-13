using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compro2_Activies_Lizarondo
{
    class Program//label????
    {
        List<List<String>> Students1 = new List<List<String>>();
        StudentInfoSystem studentInfoSystem = new StudentInfoSystem();
        static void Main()
        {
            StudentInfoSystem sias = new StudentInfoSystem();
            sias.LoginUsername();
        }
        
        //static void DemoList()
        //{
        //    //Creating a list
        //    var numbers2 = new List<int>() { 1, 2, 3, 4, 2 };

        //    foreach (var number in numbers2)
        //    {
        //        Console.WriteLine(number);
        //    }
        //    Console.WriteLine();
        //    for (int i = 0; i < numbers2.Count; i++)
        //    {
        //        Console.WriteLine(numbers2[i]);
        //        if (numbers2.Contains(2))
        //        {
        //            numbers2.Remove(2);
        //        }
        //    }


        //    //Exercise1 
        //    //Remove all occurence of item 2 in the list
        //}
        //static void MainList()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("╔════════════════════════════════════════╗");
        //        Console.WriteLine("║           Main Menu                    ║");
        //        Console.WriteLine("╠════════════════════════════════════════╣");
        //        Console.WriteLine("║ 1. Add Student                         ║");
        //        Console.WriteLine("║ 2. Update Student                      ║");
        //        Console.WriteLine("║ 3. Search Student                      ║");
        //        Console.WriteLine("║ 4. Delete Student                      ║");
        //        Console.WriteLine("║ 5. Display Student                     ║");
        //        Console.WriteLine("║ 6. DemoList                            ║");
        //        Console.WriteLine("║ 7. Exit                                ║");
        //        Console.WriteLine("╠════════════════════════════════════════╣");
        //        Console.WriteLine("║ Choose an option:                      ║");
        //        Console.WriteLine("╚════════════════════════════════════════╝");
        //        int choice = Convert.ToInt32(Console.ReadLine());
        //        Console.Clear();

        //        switch (choice)//jackowl
        //        {
        //            case 1:
        //                AddStudents();
        //                break;
        //            case 2:
        //                UpdateStudents();
        //                break;
        //            case 3:
        //                SearchStudents();
        //                break;
        //            case 4:
        //                DeleteStudents();
        //                break;
        //            case 5:
        //                DisplayStudents();
        //                break;
        //            case 6:
        //                DemoList();
        //                break;
        //            case 7:
        //                Console.WriteLine();
        //                System.Environment.Exit(0);
        //                break;
        //            default:
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("Invalid option.");
        //                Console.ResetColor();
        //                break;
        //        }
        //    }
        //}
        //static void Confirm()
        //{
        //    Console.WriteLine();
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Continue?[Y][N]");
        //    Console.ResetColor();
        //    string yes = Console.ReadLine();
        //    Console.WriteLine();

        //    if (yes == "Y".ToLower())
        //    {
        //        AddStudents();
        //    }
        //    else if (yes == "N".ToLower())
        //    {
        //        MainList();
        //    }
        //    else
        //    {
        //        Console.ForegroundColor= ConsoleColor.Red;
        //        Console.WriteLine("INVALID INPUT");
        //        Console.ResetColor();
        //        Confirm();
        //    }
        //    Console.WriteLine();
        //}
        //static void AddStudents()
        //{
        //    while (true)
        //    {//Halina't kumain sa Angel's Burger!
        //        Console.ForegroundColor = ConsoleColor.DarkBlue;
        //        Console.WriteLine("Enter student information: ");
        //        Console.ResetColor();
        //        string student1 = Console.ReadLine();
        //        Students1.AddRange(student1.Split());

        //        Confirm();
        //    }
        //}
        //static void UpdateStudents()//oh dibaaaaaaaaaa, NAKAKAPUTANGINA!!!!!!!!!
        //{
        //    Console.ForegroundColor = ConsoleColor.DarkBlue;
        //    Console.WriteLine("Enter student name to update: ");
        //    Console.ResetColor();
        //    string oldName = Console.ReadLine();

        //    Console.ForegroundColor = ConsoleColor.DarkBlue;
        //    Console.WriteLine("Enter the new name: ");
        //    Console.ResetColor();
        //    string newName = Console.ReadLine();//natatae ako

        //    for (int i = 0; i < Students1.Count; i++)
        //    {
        //        if (Students1[i] == oldName)
        //        {
        //            Students1[i] = newName;
        //        }
        //    }
        //}
        //static void SearchStudents()
        //{
        //    Console.ForegroundColor = ConsoleColor.DarkBlue;
        //    Console.WriteLine("Search Student: ");
        //    Console.ResetColor();
        //    string search = Console.ReadLine();

        //    if (Students1.Contains(search))
        //    {
        //        Console.ForegroundColor= ConsoleColor.Green;
        //        Console.WriteLine($"Student '{search}' found in list");
        //        Console.ResetColor();
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"Student '{search}' not found in list");
        //        Console.ResetColor();
        //    }

        //}
        //static void DeleteStudents()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("===================");
        //    Console.ResetColor();
        //    Console.WriteLine("Students in list");
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("===================");
        //    Console.ResetColor();

        //    foreach (var student in Students1)
        //    {
        //        Console.WriteLine($"Student: {student}");
        //    }
        //    Console.WriteLine();//oya oya oya oya

        //    Console.ForegroundColor = ConsoleColor.DarkBlue;
        //    Console.WriteLine("Input student to Delete: ");
        //    Console.ResetColor();
        //    string input = Console.ReadLine();

        //    if (Students1.Contains(input))
        //    {
        //        Students1.Remove(input);
        //        Console.WriteLine($"{input} was successfully removed");
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Student not found");
        //        Console.ResetColor();
        //    }
        //}
        //static void DisplayStudents()//KONO DIO DA
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("===================");
        //    Console.ResetColor();
        //    Console.WriteLine("Students in list");
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("===================");
        //    Console.ResetColor();

        //    foreach (var student in Students1)
        //    {
        //        Console.WriteLine($"Student: {student}");
        //    }
        //}
    }
}

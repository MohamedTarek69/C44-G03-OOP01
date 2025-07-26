using System.ComponentModel;

namespace Assignment_OOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1- Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.
            //Console.WriteLine("Days of the week:");
            //foreach (WeekDays Day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(Day);
            //}

            #endregion

            #region Q2- Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Seas_on Season;
            //bool IsParse;
            //do
            //{
            //    Console.Write("Enter Season (Spring, Summer, Autumn, Winter): ");
            //    IsParse = Enum.TryParse(Console.ReadLine(), true, out Season);
            //} while (!IsParse);

            //switch (Season)
            //{
            //    case Seas_on.Spring:
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case Seas_on.Summer:
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case Seas_on.Autumn:
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case Seas_on.Winter:
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //}

            #endregion

            #region Q3- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission existed inside variable
            //Permissions permissions = new Permissions();
            //while (true)
            //{
            //    Console.Clear();
            //    if ((int)permissions == 0)
            //    {
            //        Console.WriteLine("No permissions assigned yet.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Current Permissions: {permissions}");
            //    }
            //    int ActionInput;
            //    bool IsValidInput;
            //    do
            //    {
            //        Console.Write("Do you want to Add or Remove a permission? (1-Add | 2-Remove | 3-Exit): ");
            //        IsValidInput = int.TryParse(Console.ReadLine(), out ActionInput);

            //    } while (!IsValidInput || (ActionInput != 1 && ActionInput != 2 && ActionInput !=3));

            //    bool IsValidPerm;
            //    int PermChoice;

            //    if (ActionInput == 1)
            //    {
            //        Console.WriteLine("Adding Permission...");
            //    }
            //    else if (ActionInput == 2)
            //    {
            //        Console.WriteLine("Removing Permission...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Exiting program...");
            //        break;
            //    }
            //        do
            //        {
            //            Console.Write("Which permission? (1-Read | 2-Write | 3-Delete | 4-Execute): ");
            //            IsValidPerm = int.TryParse(Console.ReadLine(), out PermChoice);
            //        }
            //        while (!IsValidPerm || (PermChoice != 1 && PermChoice != 2&& PermChoice !=3 && PermChoice != 4));

            //    Permissions SelectedPermission;

            //    switch (PermChoice)
            //    {
            //        case 1:
            //            SelectedPermission = Permissions.Read;
            //            break;
            //        case 2:
            //            SelectedPermission = Permissions.Write;
            //            break;
            //        case 3:
            //            SelectedPermission = Permissions.Delete;
            //            break;
            //        case 4:
            //            SelectedPermission = Permissions.Execute;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid permission choice.");
            //            return;
            //    }
            //    if (ActionInput == 1)
            //    {
            //        permissions |= SelectedPermission;
            //    }
            //    else if (ActionInput == 2 && (permissions & SelectedPermission) == SelectedPermission)
            //    {
            //        permissions ^= SelectedPermission;
            //    }

            //}

            #endregion

            #region Q4- Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.Write("Enter a color: ");
            //string Input = Console.ReadLine();

            //if (Enum.TryParse(Input, true, out Colors Color))
            //{
            //    Console.WriteLine($"{Color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{Input} is not a primary color.");
            //}

            #endregion

        }
    }
}

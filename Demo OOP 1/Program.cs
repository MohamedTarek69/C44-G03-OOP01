using Common;
using Common.Access_Modifiers;
namespace Demo_OOP_1
{
    //Class
    //Struct
    //Interface
    //Enum


    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------- Video 01 -----------------------------------
            #region Class Library

            //Product product = new Product();

            #endregion
            //----------------------------------- Video 03 -----------------------------------
            #region Access Modifiers
            TypeA typeA = new TypeA();
            //typeA.x = 10;
            //typeA.y = 20;
            //typeA.z = 30;

            #endregion
            //----------------------------------- Video 04 -----------------------------------
            #region Enum

            #region Example 01
            //Person person = new Person();
            //person.Id = 10;
            //person.Name = "Ahmed";
            //person.Gender = Gender.Male;

            //Grades Grd01 = Grades.A;

            //if (Grd01 == Grades.A)
            //    Console.WriteLine("Bravo");
            //else
            //    Console.WriteLine(":(");

            //Grd01 = (Grades)10;
            //Console.WriteLine(Grd01);

            //Gender gender  = new Gender();

            //Console.WriteLine(gender);

            #endregion

            //----------------------------------- Video 05 -----------------------------------
            #region Example 02
            //Student student = new Student();
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Gender = Gender.Male,
            //    Grade = Grades.B,
            //    branch = Branch.Maadi,
            //};

            //bool isParse;
            //Console.WriteLine("Enter Student Data : ");

            //int id;

            //do
            //{
            //    Console.Write("Enter Id : ");
            //    isParse = int.TryParse(Console.ReadLine(), out id);
            //} while (!isParse);

            //student.Id = id;

            //Console.Write("Enter Name : ");
            //student.Name = Console.ReadLine();

            //object stdGender;
            //do
            //{
            //    Console.Write("Enter Gender : ");
            //    //student.Gender = Console.ReadLine()
            //    isParse = Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out stdGender);
            //} while (!isParse);

            //student.Gender = (Gender)stdGender;

            //Branch stdBranch;
            //do
            //{
            //    Console.Write("Enter Branch : ");
            //    isParse = Enum.TryParse<Branch>(Console.ReadLine(), true, out stdBranch);
            //} while (!isParse);

            //student.branch = stdBranch;

            //Grades stdGrade;
            //do
            //{
            //    Console.Write("Enter Grade : ");
            //    isParse = Enum.TryParse(Console.ReadLine(), true, out stdGrade);
            //} while (!isParse);

            //student.Grade = stdGrade;

            //Console.Clear();
            //Console.WriteLine($"Student Id : {student.Id}");
            //Console.WriteLine($"Student Name : {student.Name}");
            //Console.WriteLine($"Student Gender : {student.Gender}");
            //Console.WriteLine($"Student Branch : {student.branch}");
            //Console.WriteLine($"Student Grade : {student.Grade}");



            #endregion

            //----------------------------------- Video 06 -----------------------------------
            #region Example 03
            //User user = new User();
            //user.Id = 1;
            //user.Permisions[0] = true;
            //user.Permisions[1] = true;
            //user.Permisions[2] = false;
            //user.Permisions[3] = true;
            //user.Permissions = Permissions.Read;
            //user.Permissions = (Permissions)1;
            //user.Permissions = user.Permissions ^ Permissions.Read;
            //user.Permissions ^= Permissions.Read;
            //                         1                 4
            //                        0001
            //                        0100 = 0101 => 5
            //Console.WriteLine(user.Permissions); // Delete, Read

            //user.Permissions = user.Permissions ^ Permissions.Read;
            //user.Permissions ^= Permissions.Read;
            //                         5                 4
            //                        0101
            //                        0100 = 0001 => 1
            //Console.WriteLine(user.Permissions); // Delete

            //user.Permissions = user.Permissions ^ Permissions.Read;
            //Console.WriteLine(user.Permissions);

            //if (((user.Permissions & Permissions.Execute) == Permissions.Execute))
            //    Console.WriteLine("Permissin is Exist");
            //else
            //    user.Permissions = user.Permissions ^ Permissions.Execute;

            //user.Permissions = user.Permissions | Permissions.Execute;
            //user.Permissions |= Permissions.Execute;

            //Console.WriteLine(user.Permissions); // Delete, Execute

            #endregion

            #endregion
        }
    }
}

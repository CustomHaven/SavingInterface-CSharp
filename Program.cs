// https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-app-interfaces
using System;

namespace SavingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Add("Camping");
            tdl.Add("Swimming");
            tdl.Add("Swimming");
            tdl.Add("Swimming");


            PasswordManager pm = new PasswordManager("iluvpie1", true);

            // Q8
            tdl.Display();
            pm.Display();

            // 12
            tdl.Reset();
            pm.Reset();
            Console.WriteLine();
            tdl.Display();
            pm.Display();

            Console.WriteLine();

            bool change = pm.ChangePassword("iluvpie1", "mohamed123");
            Console.WriteLine(change);
            pm.Display();
        }
    }
}

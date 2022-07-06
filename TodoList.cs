using System;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable // implements Q4 & Q10
    {
        // PROPERTIES
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public string HeaderSymbol
        { get; }

        // CONSTRUCTOR
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        // METHODS
        public void Add(string todo)
        {
            if (nextOpenIndex < 5)
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
        }

        public void Display() // Q5
        {
            foreach (string todo in Todos)
            {
                if (String.IsNullOrEmpty(todo))
                    Console.WriteLine("[]");
                else
                    Console.WriteLine(todo);
            }
        }

        public void Reset() // Q10
        {
            Array.Clear(Todos, 0, Todos.Length); // Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}
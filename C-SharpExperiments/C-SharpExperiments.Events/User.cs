using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Events
{
    public class User
    {
        public string Name { get; set; }
        public bool IsOnline { get; set; }

        public event AccountHandler Notify;
        
        public User() { }

        public User(string name, bool isOnline)
        {
            Name = name;
            IsOnline = isOnline;
        }

        public void LogIn()
        {
            if(IsOnline == true)
            {
                Notify?.Invoke($"User with such name is already online.");
            }
            else
            {
                IsOnline = true;
                Console.WriteLine($"User {Name} get in.");
            }

        }

        public void PrintAttentionMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"User {Name}, there is a threat of hacking your accaunt. Be careful.");
        }

        

    }
}

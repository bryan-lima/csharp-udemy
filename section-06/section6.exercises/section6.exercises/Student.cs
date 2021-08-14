using System;
using System.Collections.Generic;
using System.Text;

namespace section6.exercises
{
    class Student
    {
        public Student(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Room { get; set; }
    }
}

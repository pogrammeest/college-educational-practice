using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib1
{
    public struct User
    {
        public int Id;
        public string Role;
        public string Name;

        public User(int id, string role, string name)
        {
            this.Id = id;
            this.Role = role;
            this.Name = name;
        }
    }

    public class Class1
    {
    }
}

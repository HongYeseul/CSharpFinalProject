using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPeopleDLL
{
    public class people
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public people() { }
    }

    public class User : people
    {
        public string Password { get; set; }


        public User(string name, string id, int age, string pw)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
            this.Password = pw;
        }
        public User() { }
    }

    public class Friend : people
    {
        public bool BestFriend { get; set; }

        public Friend(string name, string id, int age, bool bf)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
            this.BestFriend = bf;
        }
        public Friend() { }
    }
}

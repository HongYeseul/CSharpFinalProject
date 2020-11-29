using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPeopleDLL
{
    interface people
    {
        string returnName();
        string returnId();
        string returnAge();
    }

    public class User : people
    {
        string name;
        string id;
        int age;
        string pw;
        public string Password { get; set; }


        public User(string name, string id, int age, string pw)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.Password = pw;
        }

        public string returnName()
        {
            return this.name;
        }
        public string returnId()
        {
            return this.id;
        }
        public string returnAge()
        {
            return this.age.ToString();
        }
    }

    public class Friend : people
    {
        string name;
        string id;
        int age;
        public bool BestFriend { get; set; }

        public Friend(string name, string id, int age, bool bf)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.BestFriend = bf;
        }
        public string returnName()
        {
            return this.name;
        }
        public string returnId()
        {
            return this.id;
        }
        public string returnAge()
        {
            return this.age.ToString();
        }
    }
}

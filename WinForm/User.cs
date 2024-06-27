using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    class User
    {
        int id;string name, password, question, answer;

        public User(int id, string name, string password, string question, string answer)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.question = question;
            this.answer = answer;
        }

        public User(string name, string password, string question, string answer)
        {
            this.name = name;
            this.password = password;
            this.question = question;
            this.answer = answer;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Question { get => question; set => question = value; }
        public string Answer { get => answer; set => answer = value; }
    }
}

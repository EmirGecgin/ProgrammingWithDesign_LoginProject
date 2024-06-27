using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    class UserManager
    {
        static UserManager usermanager;
        List<User> users = new List<User>()
        {
            new User(1, "Serdar", "12345", "en sevdiğiniz marka?", "honda"),
            new User(2, "Mehmet", "12345", "en sevdiğiniz yemek?", "mantı"),
            new User(3, "Ayşegül", "12345", "en sevdiğiniz renk?", "mavi")
        };

        private UserManager()
        {
            
        }

        public string AddUser(User user)
        {
            try
            {
                if(!IsUserComplete(user))
                {
                    return "Kullanıcı bilgileri eklenemez!";
                }
                if (!IsPasswordComplete(user.Password))
                {
                    return "Şifre en az 8 karakter olmalı ve 12345 içermemelidir!";
                }
                users.Add(user);
                return user.Name + " Kullanıcı eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdatePassword(int userId,string password)
        {
            try
            {
                if (!IsPasswordComplete(password))
                {
                    return "Şifre en az 8 karakter olmalı ve 12345 içermemelidir!";
                }
                foreach (User item in users)
                {
                    if (item.Id == userId)
                    {
                        item.Password=password;
                        return item.Name + " Kullanıcısının şifresi güncellendi";
                    }
                }
                return "Kullanıcı bulunamadı";
            }
            catch (Exception ex)
            {
                return ex.Message;
                
            }
        }
        public bool LoginControl(string username, string password)
        {
            try
            {
                foreach (User item in users)
                {
                    if(item.Name==username && item.Password == password)
                    {
                           return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        bool IsUserComplete(User user)
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Question) || string.IsNullOrEmpty(user.Answer) || string.IsNullOrEmpty(user.Password))
            {
                return false;
            }
            return true;
        }
        bool IsPasswordComplete(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            if (password.Length < 8||password.Contains("12345"))
            {
                return false;   
            }
            return true;
        }
        public int GetUserIdByUsername(string username)
        {
            foreach (User item in users)
            {
                if (item.Name == username)
                {
                    return item.Id;
                }
            }
            return -1;
        }
        public string GetQuestionByUserId(int userId)
        {
            foreach (User item in users)
            {
                if (item.Id == userId)
                {
                    return item.Question;
                }
            }
            return "";
        }
        public bool ControlAnswer(int userId,string answer)
        {
            answer = answer.Trim();
            foreach (User item in users)
            {
                if(item.Id==userId && answer == item.Answer)
                {
                    return true;
                }
            }
            return false;
        }
        public static UserManager GetInstance()
        {
            if (usermanager == null)
            {
                usermanager=new UserManager();
            }
            return usermanager;
        }
    }
}

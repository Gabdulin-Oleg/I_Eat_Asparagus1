using I_Eat_Spargus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I_Eat_Spargus.DB
{
    public static class Operation
    {

        public static void Creat(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public static User Read(string gmail)
        {
            using (Context db = new Context())
            {
                foreach (var user in db.Users)
                {
                    if (user.Gmail == gmail)
                    {
                        return user;
                    }
                }
                return null;
            }
        }
        public static User ReadDate(DateTime date)
        {
            using (Context db = new Context())
            {
                foreach (var user in db.Users)
                {
                    if (user.Date == date)
                    {
                        return user;
                    }
                }
                return null;
            }
        }
        public static void UpDate(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Update(user);
                db.SaveChanges();
            }
        }
        public static void Delete(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
        public static IOrderedEnumerable<User> AllUsers()
        {
            List<User> AllUsers = new List<User>();
            using (Context db = new Context())
            {

                foreach (var user in db.Users)
                {
                    AllUsers.Add(user);
                }

            }
            var sortUser = from item in AllUsers
                           orderby item.Date descending
                           select item;

            return sortUser;
        }
       

        
    }
}

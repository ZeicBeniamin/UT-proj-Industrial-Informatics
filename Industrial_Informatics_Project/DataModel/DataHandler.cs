using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.DataModel
{
    class DataHandler
    {
        public static bool insertUser(string username, string email, string password)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {

                IList<User> users = (from usr in entities.Users
                                                  select usr)
                .OrderBy(usr => usr.user_id)
                .ToList();
                int last_id = users.Count;
        
                var user = new User
                    {
                        user_id = last_id,
                        user_name = username,
                        email = email,
                        password = password
                    };

                if (entities.Users.Add(user) != null)
                {
                    entities.SaveChanges();
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public static bool isAdmin(string user_name,string password)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {
                var user = entities.Users.SingleOrDefault(u => u.user_name == user_name && u.password == password);

                if (user != null)
                {
                    if (user.isAdmin == 1)
                        return true;
                }
            }
            return false;
        }

        public static bool isUser(string user_name, string password)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {
                var user = entities.Users.SingleOrDefault(u => u.user_name == user_name && u.password == password);

                if (user != null)
                        return true;              
            }
            return false;
        }

        public static bool existsUser(string email)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {
                var user = entities.Users.SingleOrDefault(u => u.email == email);

                if (user != null)
                    return true;
            }
            return false;
        }

        public static int getUserId(string user_name, string password)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {
                var user = entities.Users.SingleOrDefault(u => (u.user_name == user_name && u.password == password));

                if (user != null)
                {
                    return user.user_id;
                }
            }
            return -1;
        }
    }
}

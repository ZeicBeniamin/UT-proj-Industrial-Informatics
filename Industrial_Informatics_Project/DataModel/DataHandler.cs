using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.DataModel
{
    class DataHandler
    {
        static void insertUniversity(int id, string name, string city, int code)
        {
            int startIndex = 0;
            II_ProjectEntities entities = new II_ProjectEntities();
            IList<User> users = (from user in entities.Universities
                                                  select user)
                .OrderBy(university => university.Id)
                .Skip(startIndex)
                .ToList();
                textBox_universities.Text = "";
                foreach (University uni in users)
                {
                    string university = uni.Id + " " + uni.NameUniv + " " + uni.City + " " + uni.Code + Environment.NewLine;
                    textBox_universities.Text += university;
                }
            



        }

        static void deleteUniversity(int code)
        {
           
        }

        static void updateUniversity(int id, string name, string city, int code)
        {
           
        }
    }
}

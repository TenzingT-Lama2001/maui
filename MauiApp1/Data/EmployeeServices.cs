
using MauiApp1.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class EmployeeServices
    {
        public static List<EmployeeModel> Employees()
        {
            return new List<EmployeeModel>
            {
                new EmployeeModel{name="Ram Baral", email="ram@gmail.com", phone=1234567890, age=20, gender="male", position="Cloud Engineer", salary=90000, education="bachelors", department="Cloud"},

                new EmployeeModel{name="Dazn Lama", email="dazn@gmail.com", phone=1234467890, age=22, gender="female", position="Cloud Engineer", salary=100000, education="bachelors", department="Cloud"},

                new EmployeeModel{name="Callux Dong", email="Callux@gmail.com", phone=3234567890, age=24, gender="male", position="Project Manager", salary=200000, education="masters", department="Development"},

                new EmployeeModel{name="Harry Styles", email="Harry@gmail.com", phone=4234567890, age=21, gender="male", position="QA", salary=70000, education="masters", department="Development"},

                new EmployeeModel{name="Money Man", email="Money@gmail.com", phone=5235567890, age=20, gender="female", position="Backend", salary=60000, education="masters", department="Development"},

                new EmployeeModel{name="Hello World", email="Hello@gmail.com", phone=8234567890, age=25, gender="male", position="Frontend", salary=82000, education="bachelors", department="Development"},

                new EmployeeModel{name="Sandesh Man", email="Sandesh@gmail.com", phone=9334567890, age=30, gender="female", position="Backend", salary=10000, education="bachelors", department="Development"},

                new EmployeeModel{name="Bat Man", email="Bat@gmail.com", phone=7234567890, age=35, gender="male", position="Frontend", salary=500000, education="bachelors", department="Development"},

                new EmployeeModel{name="Super Man", email="Super@gmail.com", phone=6434667890, age=31, gender="female", position="UI/UX", salary=700000, education="masters", department="Design"},

                new EmployeeModel{name="Spider Woman", email="Spider@gmail.com", phone=8134567890, age=21, gender="female", position="Product Designer", salary=155000,education="masters", department="Design"},

            };
        }

        //sorting 

        public static List<EmployeeModel> FilterEmployeeByName(string name)
        {
            return EmployeeServices.Employees().Where(emp => (emp.name.Contains(name,StringComparison.OrdinalIgnoreCase))).ToList();
        }

        public static List<EmployeeModel> SortListByAge()
        {
            return EmployeeServices.Employees().OrderBy(x => x.age).ToList();
        }



        public static List<EmployeeModel> SortListInDesc()
        {
            return EmployeeServices.Employees().OrderByDescending(emp => emp.age).ToList();

        }
    }
       
}

using System;
using System.Collections.Generic;
using System.Text;

namespace dsd_json
{
    public class UserModel
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Salary { get; private set; }

        public UserModel(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Nome = { Name }, Age = { Age }, Salary = { Salary }";
        }
    }
}

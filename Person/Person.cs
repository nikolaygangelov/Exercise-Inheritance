using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;
        private string name;


        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual int Age
        {
            get { return age; }
            set 
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));

            return stringBuilder.ToString();

        }

    }
}

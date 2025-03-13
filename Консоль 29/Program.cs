﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;

namespace _28
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                Student[] students = InputPeople<Student>(3);
                List<Employee> employees = InputPeople<Employee>(3);


                Console.Write("Вывести студентов (s) или работников (e)? ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (char.ToLower(choice))
                {
                    case 's':
                        OutputPeople(students);
                        break;
                    case 'e':
                        OutputPeople(employees);
                        break;
                }

                Console.ReadKey(true);
            }

            static T[] InputPeople<T>(int length) where T : Person
            {
                T[] people = new T[length];
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"Введите данные {i + 1}-го {(typeof(T) == typeof(Student) ? "студента" : "работника")}:");


                    string name = InputString("Имя");
                    string surname = InputString("Фамилия");
                    int age = InputInt("Возраст");
                    string specificInfo = InputString(typeof(T) == typeof(Student) ? "Курс" : "Должность");

                    if (typeof(T) == typeof(Student))
                    {
                        DateTime dateOfBirth = InputDateTime("Дата рождения");
                        people[i] = (T)(object)new Student(name, surname, age, dateOfBirth, specificInfo);  // Casting to T
                    }
                    else
                    {
                        string company = InputString("Название предприятия");
                        people[i] = (T)(object)new Employee(name, surname, age, company, specificInfo);  // Casting to T
                    }
                }

                return people;
            }


            static string InputString(string prompt)
            {
                Console.Write($"{prompt}: ");
                return Console.ReadLine();
            }

      
            static int InputInt(string prompt)
            {
                Console.Write($"{prompt}: ");
                return int.Parse(Console.ReadLine());
            }

          
            static DateTime InputDateTime(string prompt)
            {
                Console.Write($"{prompt}: ");
                return DateTime.Parse(Console.ReadLine());
            }

        
            static void OutputPeople<T>(IEnumerable<T> people) where T : Person
            {
                Console.WriteLine("Список: ");
                foreach (var person in people)
                {
                    Console.WriteLine($"  {person}");
                }
            }
        }
    }
    }
}

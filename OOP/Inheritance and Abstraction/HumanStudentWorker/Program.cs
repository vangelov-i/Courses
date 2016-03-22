using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            List<Worker> workersList = new List<Worker>();
            List<Human> peopleList = new List<Human>();

            studentsList.Add(new Student("Jivko", "Sabqta", "12345"));
            studentsList.Add(new Student("Toshko", "Gyrbaviq", "234567"));
            studentsList.Add(new Student("Mitio", "Ochite", "345678"));
            studentsList.Add(new Student("Marin", "Tuglata", "456789"));
            studentsList.Add(new Student("Spas", "Abniq", "567890"));
            studentsList.Add(new Student("Serafim", "Sexa", "678901"));
            studentsList.Add(new Student("Zdravko", "Loshiq", "789012"));
            studentsList.Add(new Student("Mitko", "Qkuzata", "890123"));
            studentsList.Add(new Student("Oleg", "Vlata", "901234"));
            studentsList.Add(new Student("Penka", "Obshtata", "012345"));


            workersList.Add(new Worker("Goshko", "Rabotniq", 150, 4));
            workersList.Add(new Worker("Velio", "Myrzela", 50, 2));
            workersList.Add(new Worker("Onq", "Myrdata", 100, 7));
            workersList.Add(new Worker("Toq", "Myglata", 110, 8));
            workersList.Add(new Worker("Malkiq", "Muk", 200, 8));
            workersList.Add(new Worker("Misho", "Sharana", 120, 6));
            workersList.Add(new Worker("Martin", "Shebeka", 234, 9));
            workersList.Add(new Worker("Mario", "Galfona", 145, 10));
            workersList.Add(new Worker("Miro", "Sadjaka", 87, 11));
            workersList.Add(new Worker("Koceto", "Kriviq", 132, 12));

            Console.WriteLine(workersList[0]);

            studentsList.Sort((a, b) => a.FacultyNumber.CompareTo(b.FacultyNumber));

            workersList = workersList.OrderByDescending(f => f.MoneyPerHour()).ToList();

            peopleList.AddRange(workersList.Cast<Human>());
            peopleList.AddRange(studentsList.Cast<Human>());
            
            peopleList = peopleList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach (Human human in peopleList)
            {
                Console.WriteLine(human);
            }



        }
    }
}

namespace _01ClassStudent
{
    using System.Collections.Generic;

    public static class StudentsData
    {
        public static IList<Student> Students => GetStudentsList();

        private static IList<Student> GetStudentsList()
        {
            var gosho = new Student(
                    "Goshko",
                    "Kirkata",
                    25,
                    "000114",
                    "+3592001",
                    "gosho_loshiq@abv.bg",
                    new List<int> { 2, 3, 4 },
                    "grupa 1");
            var joro = new Student(
                    "Joro",
                    "Jicata",
                    23,
                    "000215",
                    "+359002",
                    "joro_jicata@gmail.com",
                    new List<int> { 4, 5, 6 },
                    "grupa 2");
            var petranka = new Student(
                    "Petranka",
                    "Obshtata",
                    27,
                    "000314",
                    "+359003",
                    "sexy_f-4e@hotmail.com",
                    new List<int> { 2, 2, 3 },
                    "grupa 1");
            var penka = new Student(
                    "Penka",
                    "Jricata",
                    22,
                    "000414",
                    "+359004",
                    "Penka_umnata@abv.bg",
                    new List<int> { 5, 5, 6 },
                    "grupa 2");

            var students = new List<Student> { gosho, joro, petranka, penka };

            return students;
        }
    }
}

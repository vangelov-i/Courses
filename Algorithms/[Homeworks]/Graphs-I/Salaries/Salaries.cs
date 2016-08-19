using System;
using System.Collections.Generic;
using System.Linq;

class Salaries
{
    private static IDictionary<int, List<int>> salaryGraph;
    private static IDictionary<int, int> salaries;
    private static IDictionary<int, int> employeesManagers;

    static void Main()
    {
        salaries = new Dictionary<int, int>();
        employeesManagers = new Dictionary<int, int>();

        salaryGraph = ReadGraph();
        //List<int> bosses = salaryGraph.Keys.Where(b => salaryGraph.Values.All(v => !v.Contains(b))).ToList();
        List<int> bosses = employeesManagers.Where(emp => emp.Value == 0).Select(k => k.Key).ToList();

        foreach (int boss in bosses)
        {
            salaries[boss] = CalculateSalary(boss);
        }

        Console.WriteLine(salaries.Values.Sum());
    }

    private static int CalculateSalary(int employee)
    {
        if (salaries[employee] != 0)
        {
            return salaries[employee];
        }

        foreach (var subordinate in salaryGraph[employee])
        {
            salaries[employee] += CalculateSalary(subordinate);
        }

        return salaries[employee];
    }

    private static IDictionary<int, List<int>> ReadGraph()
    {
        var result = new Dictionary<int, List<int>>();

        int numberOfEmplyees = int.Parse(Console.ReadLine());
        for (int employee = 0; employee < numberOfEmplyees; employee++)
        {
            result[employee] = new List<int>();
            if (!employeesManagers.ContainsKey(employee))
            {
                employeesManagers[employee] = 0;
            }

            string subordinates = ParseSubordinates(result, employee);

            InitializeSalaries(employee, subordinates);
        }

        return result;
    }

    private static void InitializeSalaries(int employee, string subordinates)
    {
        if (subordinates.IndexOf('Y') == -1)
        {
            salaries[employee] = 1;
        }
        else
        {
            salaries[employee] = 0;
        }
    }

    private static string ParseSubordinates(Dictionary<int, List<int>> result, int employee)
    {
        string subordinates = Console.ReadLine();
        for (int subordinate = 0; subordinate < subordinates.Length; subordinate++)
        {
            if (subordinates[subordinate] == 'Y')
            {
                if (!employeesManagers.ContainsKey(subordinate))
                {
                    employeesManagers[subordinate] = 0;
                }

                employeesManagers[subordinate]++;
                result[employee].Add(subordinate);
            }
        }

        return subordinates;
    }
}
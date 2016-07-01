using System;
using System.Collections.Generic;
using System.Linq;

public class PersonCollectionSlow : IPersonCollection
{
    // TODO: define the underlying data structures here ...
    private List<Person> persons = new List<Person>(); 

    public bool AddPerson(string email, string name, int age, string town)
    {
        if (this.persons.Any(p => p.Email == email))
        {
            return false;
        }

        var person = new Person(email, name, age, town);
        this.persons.Add(person);

        return true;
    }

    public int Count => this.persons.Count;

    public Person FindPerson(string email)
    {
        var result = this.persons.FirstOrDefault(p => p.Email == email);

        return result;
    }

    public bool DeletePerson(string email)
    {
        for (int i = 0; i < this.Count; i++)
        {
            var currentPerson = this.persons[i];
            if (currentPerson.Email == email)
            {
                this.persons.RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    public IEnumerable<Person> FindPersons(string emailDomain)
    {
        var filteredBtEmailDomain = new List<Person>();
        string domain = "@" + emailDomain;
        for (int index = 0; index < this.Count; index++)
        {
            var candidate = this.persons[index];
            if (candidate.Email.Contains(domain))
            {
                filteredBtEmailDomain.Add(candidate);
            }
        }

        return filteredBtEmailDomain.OrderBy(p => p.Email);
    }

    public IEnumerable<Person> FindPersons(string name, string town)
    {
        var filteredByNameAndTown = this.persons
            .Where(p => p.Name == name && p.Town == town)
            .OrderBy(p => p.Email);

        return filteredByNameAndTown;
    }

    public IEnumerable<Person> FindPersons(int startAge, int endAge)
    {
        var filteredByAgeRange = this.persons
            .Where(p => p.Age >= startAge && p.Age <= endAge)
            .OrderBy(p => p.Age)
            .ThenBy(p => p.Email);

        return filteredByAgeRange;
    }

    public IEnumerable<Person> FindPersons(
        int startAge, int endAge, string town)
    {
        var filteredByAgeRangeAndTown = this.FindPersons(startAge, endAge)
            .Where(p => p.Town == town);

        return filteredByAgeRangeAndTown;
    }

    private void Foreach(Action<Person> action)
    {
        
    }
}

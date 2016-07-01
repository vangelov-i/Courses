using System.Collections.Generic;

using Wintellect.PowerCollections;

public class PersonCollection : IPersonCollection
{
    // TODO: define the underlying data structures here ...
    private Dictionary<string, Person> peopleByEmail;
    private Dictionary<string, SortedSet<Person>> peopleByDomain;
    private Dictionary<string, SortedSet<Person>> peopleByNameTown;
    private OrderedDictionary<int, SortedSet<Person>> peopleByAge;
    private Dictionary<string, OrderedDictionary<int, SortedSet<Person>>> peopleByTownAndAge;

    public PersonCollection()
    {
        this.peopleByEmail = new Dictionary<string, Person>();
        this.peopleByAge = new OrderedDictionary<int, SortedSet<Person>>();
        this.peopleByNameTown = new Dictionary<string, SortedSet<Person>>();
        this.peopleByDomain = new Dictionary<string, SortedSet<Person>>();
        this.peopleByTownAndAge = new Dictionary<string, OrderedDictionary<int, SortedSet<Person>>>();
    }

    public bool AddPerson(string email, string name, int age, string town)
    {
        if (this.peopleByEmail.ContainsKey(email))
        {
            return false;
        }

        var personToAdd = new Person(email, name, age, town);

        this.peopleByEmail.Add(email, personToAdd);
        if (!this.peopleByAge.ContainsKey(age))
        {
            this.peopleByAge[age] = new SortedSet<Person>();
        }

        this.peopleByAge[age].Add(personToAdd);

        string nameTown = name + " " + town;
        if (!this.peopleByNameTown.ContainsKey(nameTown))
        {
            this.peopleByNameTown[nameTown] = new SortedSet<Person>();
        }

        this.peopleByNameTown[nameTown].Add(personToAdd);

        var domain = email.Substring(email.LastIndexOf('@') + 1);
        if (!this.peopleByDomain.ContainsKey(domain))
        {
            this.peopleByDomain[domain] = new SortedSet<Person>();
        }

        this.peopleByDomain[domain].Add(personToAdd);

        if (! this.peopleByTownAndAge.ContainsKey(town))
        {
            this.peopleByTownAndAge[town] = new OrderedDictionary<int, SortedSet<Person>>();
        }

        if (! this.peopleByTownAndAge[town].ContainsKey(age))
        {
            this.peopleByTownAndAge[town][age] = new SortedSet<Person>();
        }

        this.peopleByTownAndAge[town][age].Add(personToAdd);

        return true;
    }

    public int Count => this.peopleByEmail.Count;

    public Person FindPerson(string email)
    {
        Person result;
        this.peopleByEmail.TryGetValue(email, out result);

        return result;
    }

    public bool DeletePerson(string email)
    {
        if (!this.peopleByEmail.ContainsKey(email))
        {
            return false;
        }

        var personToRemove = this.peopleByEmail[email];
        this.peopleByEmail.Remove(email);
        this.peopleByAge[personToRemove.Age].Remove(personToRemove);
        var nameTown = personToRemove.Name + " " + personToRemove.Town;
        this.peopleByNameTown[nameTown].Remove(personToRemove);
        var domain = email.Substring(email.LastIndexOf('@') + 1);
        this.peopleByDomain[domain].Remove(personToRemove);
        this.peopleByTownAndAge[personToRemove.Town][personToRemove.Age].Remove(personToRemove);

        return true;
    }

    public IEnumerable<Person> FindPersons(string emailDomain)
    {
        if (!this.peopleByDomain.ContainsKey(emailDomain))
        {
            return new Person[0];
        }

        var filteredByDomain = this.peopleByDomain[emailDomain];

        return filteredByDomain;
    }

    public IEnumerable<Person> FindPersons(string name, string town)
    {
        var key = name + " " + town;
        if (!this.peopleByNameTown.ContainsKey(key))
        {
            return new Person[0];
        }

        var filteredByNameTowm = this.peopleByNameTown[key];

        return filteredByNameTowm;
    }

    public IEnumerable<Person> FindPersons(int startAge, int endAge)
    {
        var filteredByAge = this.peopleByAge.Range(startAge, true, endAge, true).Values;

        foreach (var people in filteredByAge)
        {
            foreach (var person in people)
            {
                yield return person;
            }
        }
    }

    public IEnumerable<Person> FindPersons(
        int startAge, int endAge, string town)
    {
        if (! this.peopleByTownAndAge.ContainsKey(town))
        {
            yield break;
        }

        var filteredByAge = this.peopleByTownAndAge[town].Range(startAge, true, endAge, true).Values;

        foreach (var people in filteredByAge)
        {
            foreach (var person in people)
            {
                yield return person;
            }
        }
    }
}
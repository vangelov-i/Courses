
using System;
using System.Collections.Generic;

public class BiDictionary<K1, K2, T>
{
    private Dictionary<K1, List<T>> valuseByFirstKey;
    private Dictionary<K2, List<T>> valuseBySecondKey;
    private Dictionary<Tuple<K1, K2>, List<T>> valuesByBothKeys;

    public BiDictionary()
    {
        this.valuseByFirstKey = new Dictionary<K1, List<T>>();
        this.valuseBySecondKey = new Dictionary<K2, List<T>>();
        this.valuesByBothKeys = new Dictionary<Tuple<K1, K2>, List<T>>();
    }

    public void Add(K1 key1, K2 key2, T value)
    {
        if (! this.valuseByFirstKey.ContainsKey(key1))
        {
            this.valuseByFirstKey[key1] = new List<T>();
        }

        this.valuseByFirstKey[key1].Add(value);

        if (! this.valuseBySecondKey.ContainsKey(key2))
        {
            this.valuseBySecondKey[key2] = new List<T>();
        }

        this.valuseBySecondKey[key2].Add(value);

        var coupleToAdd = new Tuple<K1, K2>(key1, key2);
        if (! this.valuesByBothKeys.ContainsKey(coupleToAdd))
        {
            this.valuesByBothKeys[coupleToAdd] = new List<T>();
        }

        this.valuesByBothKeys[coupleToAdd].Add(value);
    }

    public bool Remove(K1 key1, K2 key2)
    {
        var couple = new Tuple<K1, K2>(key1, key2);
        if (! this.valuesByBothKeys.ContainsKey(couple))
        {
            return false;
        }

        var distanceToRemove = this.valuesByBothKeys[couple];
        this.valuesByBothKeys.Remove(couple);

        foreach (var distance in distanceToRemove)
        {
            this.valuseByFirstKey[key1].Remove(distance);
            this.valuseBySecondKey[key2].Remove(distance);
        }

        if (this.valuseByFirstKey[key1].Count == 0)
        {
            this.valuseByFirstKey.Remove(key1);
        }

        if (this.valuseBySecondKey[key2].Count == 0)
        {
            this.valuseBySecondKey.Remove(key2);
        }

        return true;
    }

    public IEnumerable<T> Find(K1 key1, K2 key2)
    {
        var couple = new Tuple<K1, K2>(key1, key2);

        if (! this.valuesByBothKeys.ContainsKey(couple))
        {
            yield break;
        }

        foreach (var distance in this.valuesByBothKeys[couple])
        {
            yield return distance;
        }
    }

    public IEnumerable<T> FindByKey1(K1 key1)
    {
        if (! this.valuseByFirstKey.ContainsKey(key1))
        {
            yield break;
        }

        foreach (var distance in this.valuseByFirstKey[key1])
        {
            yield return distance;
        }
    }

    public IEnumerable<T> FindByKey2(K2 key2)
    {
        if (!this.valuseBySecondKey.ContainsKey(key2))
        {
            yield break;
        }

        foreach (var distance in this.valuseBySecondKey[key2])
        {
            yield return distance;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class HashTable<TKey, TValue> : IEnumerable<KeyValue<TKey, TValue>>
{
    private const double MaxFillFactor = 0.75;

    private LinkedList<KeyValue<TKey, TValue>>[] slots;

    public int Count { get; private set; }

    public int Capacity => this.slots.Length;

    private double FillFactor => (this.Count + 1.0) / this.Capacity;

    public HashTable(int capacity = 32)
    {
        this.slots = new LinkedList<KeyValue<TKey, TValue>>[capacity];
    }

    public void Add(TKey key, TValue value)
    {
        if (this.ContainsKey(key))
        {
            throw new ArgumentException("The key already exists.");
        }

        if (this.FillFactor >= MaxFillFactor)
        {
            this.Grow();
        }

        int position = this.GenerateSlotPosition(key);
        if (this.slots[position] == null)
        {
            this.slots[position] = new LinkedList<KeyValue<TKey, TValue>>();
        }

        var kvpToAdd = new KeyValue<TKey, TValue>(key, value);
        this.slots[position].AddLast(kvpToAdd);
        this.Count++;
    }

    public bool AddOrReplace(TKey key, TValue value)
    {
        int slotPosition = this.GenerateSlotPosition(key);

        if (this.slots[slotPosition] == null)
        {
            this.slots[slotPosition] = new LinkedList<KeyValue<TKey, TValue>>();
        }

        foreach (var keyValuePair in this.slots[slotPosition])
        {
            if (keyValuePair.Key.Equals(key))
            {
                keyValuePair.Value = value;
                return false;
            }
        }

        var kvpToAdd = new KeyValue<TKey, TValue>(key, value);
        this.slots[slotPosition].AddLast(kvpToAdd);

        this.Count++;

        return true;
    }

    public TValue Get(TKey key)
    {
        int slotToSearch = this.GenerateSlotPosition(key);
        if (this.slots[slotToSearch] == null)
        {
            throw new KeyNotFoundException("The given key does not exist.");
        }

        foreach (var keyValuePair in this.slots[slotToSearch])
        {
            if (keyValuePair.Key.Equals(key))
            {
                return keyValuePair.Value;
            }
        }

        throw new KeyNotFoundException("The given key does not exist.");
    }

    public TValue this[TKey key]
    {
        get
        {
            return this.Get(key);
        }
        set
        {
            this.AddOrReplace(key, value);
            return;

            int position = this.GenerateSlotPosition(key);
            if (this.slots[position] == null)
            {
                throw new ArgumentException("The given key does not exist.");
            }

            foreach (var keyValuePair in this.slots[position])
            {
                if (keyValuePair.Key.Equals(key))
                {
                    keyValuePair.Value = value;
                    return;
                }
            }

            throw new ArgumentException("The given key does not exist.");
        }
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        int position = this.GenerateSlotPosition(key);
        if (this.slots[position] == null)
        {
            value = default(TValue);
            return false;
        }

        foreach (var keyValuePair in this.slots[position])
        {
            if (keyValuePair.Key.Equals(key))
            {
                value = keyValuePair.Value;
                return true;
            }
        }

        value = default(TValue);
        return false;
    }

    public KeyValue<TKey, TValue> Find(TKey key)
    {
        int position = this.GenerateSlotPosition(key);
        if (this.slots[position] == null)
        {
            return null;
        }

        foreach (var keyValuePair in this.slots[position])
        {
            if (keyValuePair.Key.Equals(key))
            {
                return keyValuePair;
            }
        }

        return null;
    }

    public bool ContainsKey(TKey key)
    {
        int slotPosition = this.GenerateSlotPosition(key);
        if (this.slots[slotPosition] == null)
        {
            return false;
        }

        foreach (var keyValuePair in this.slots[slotPosition])
        {
            if (keyValuePair.Key.Equals(key))
            {
                return true;
            }
        }

        return false;
    }

    public bool Remove(TKey key)
    {
        int slotPosition = this.GenerateSlotPosition(key);
        if (this.slots[slotPosition] == null)
        {
            return false;
        }

        foreach (var keyValuePair in this.slots[slotPosition])
        {
            if (keyValuePair.Key.Equals(key))
            {
                this.slots[slotPosition].Remove(keyValuePair);
                this.Count--;

                return true;
            }
        }

        return false;
    }

    public void Clear()
    {
        for (int index = 0; index < this.Capacity; index++)
        {
            this.slots[index] = null;
        }

        this.Count = 0;
    }

    public IEnumerable<TKey> Keys
    {
        get
        {
            var keys = new List<TKey>(this.Capacity);
            for (int index = 0; index < this.Capacity; index++)
            {
                if (this.slots[index] != null)
                {
                    keys.AddRange(this.slots[index].Select(kvp => kvp.Key));
                }
            }

            return keys;
        }
    }

    public IEnumerable<TValue> Values
    {
        get
        {
            var values = new List<TValue>(this.Capacity);
            for (int index = 0; index < this.Capacity; index++)
            {
                if (this.slots[index] != null)
                {
                    values.AddRange(this.slots[index].Select(kvp => kvp.Value));
                }
            }

            return values;
        }
    }

    public IEnumerator<KeyValue<TKey, TValue>> GetEnumerator()
    {
        for (int index = 0; index < this.Capacity; index++)
        {
            if (this.slots[index] != null)
            {
                foreach (var keyValuePair in this.slots[index])
                {
                    yield return keyValuePair;
                }
            }
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private int GenerateSlotPosition(TKey key)
    {
        int slotPosition = Math.Abs(key.GetHashCode()) % this.Capacity;
        return slotPosition;
    }

    private void Grow()
    {
        var newSlots = new LinkedList<KeyValue<TKey, TValue>>[this.Capacity * 2];
        for (int index = 0; index < this.Capacity; index++)
        {
            if (this.slots[index] == null)
            {
                continue;
            }

            foreach (var keyValuePair in this.slots[index])
            {
                int newPosition = Math.Abs(keyValuePair.Key.GetHashCode()) % newSlots.Length;

                if (newSlots[newPosition] == null)
                {
                    newSlots[newPosition] = new LinkedList<KeyValue<TKey, TValue>>();
                }

                newSlots[newPosition].AddLast(keyValuePair);
            }
        }

        this.slots = newSlots;
    }
}

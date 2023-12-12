using System;
using System.Collections;
using System.Collections.Generic;

public class CustomCollection<T> : IEnumerable<T>
{
    private T[] array;
    private int count;

    public CustomCollection()
    {
        array = new T[5];
        count = 0;
    }

    public void Sort()
    {
        Array.Sort(array, 0, count); ;
    }

    public void Add(T item)
    {
        EnsureCapacity();
        array[count] = item;
        count++;
    }

    public void SetDefaultAt(int index, T defaultValue)
    {
        if (index >= 0 && index < count)
        {
            array[index] = defaultValue;
        }
        else
        {
            throw new Exception();
        }
    }

    private void EnsureCapacity()
    {
        if (count == array.Length)
        {
            Array.Resize(ref array, array.Length * 2);
        }
    }
    public int Count()
    {
        return count;
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return array[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


using System.Collections.Generic;
using UnityEngine;

public class Generics : MonoBehaviour
{
    public List<int> numbers;
    public List<string> words;

    private void Start()
    {
        words = ReverseList(words);
        numbers = ReverseList(numbers);
    }

    private List<T> ReverseList<T>(List<T> listToReverse)
    {
        List<T> reversedList = new List<T>();

        for (int i = listToReverse.Count - 1; i >= 0; i--)
        {
            reversedList.Add(listToReverse[i]);
        }

        return reversedList;
    }
}

using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    [Header("Content")]
    public GameObject[] myContent;

    [Header("Stack")]
    public Stack<GameObject> cardsStack;

    private void Start()
    {
        //init
        cardsStack = new Stack<GameObject>();

        //add
        for (int i = 0; i < myContent.Length; i++)
        {
            cardsStack.Push(myContent[i]);
        } 

        //return first and remove
        GameObject myGameObjectPop = cardsStack.Pop();

        //return first
        GameObject myGameObjectPeak = cardsStack.Peek();

        //contains
        bool contains = cardsStack.Contains(myGameObjectPop);

        //amount
        int amount = cardsStack.Count;

        //clear 
        cardsStack.Clear();


    }
}

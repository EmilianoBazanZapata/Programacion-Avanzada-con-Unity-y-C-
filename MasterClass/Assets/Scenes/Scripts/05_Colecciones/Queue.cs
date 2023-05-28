using System.Collections.Generic;
using UnityEngine;

public class Queue : MonoBehaviour
{
    [Header("Content")]
    public GameObject[] myContent;

    [Header("Queue")]
    public Queue<GameObject> playerQueue;

    private void Start()
    {
        //init 
        playerQueue = new Queue<GameObject>();

        //add
        for (int i = 0; i < myContent.Length; i++)
        {
            playerQueue.Enqueue(myContent[i]);
        }

        //remove
        GameObject myGameObject = playerQueue.Dequeue();

        //contains
        bool contains = playerQueue.Contains(myGameObject);

        //amount
        int amount = playerQueue.Count;

        //clear
        playerQueue.Clear();    
    }
}

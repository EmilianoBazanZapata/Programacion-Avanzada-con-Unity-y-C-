using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    [Header("Content")]
    public int[] myContent;

    [Header("List")]
    public List<int> weaponsList;


    private void Start()
    {
        weaponsList = new List<int>();

        //add
        for (int i = 0; i < myContent.Length; i++)
        {
            weaponsList.Add(myContent[i]);
        }

        weaponsList.AddRange(myContent);

        //remove
        weaponsList.Remove(myContent[2]);

        //read
        int tempValue = weaponsList[2];

        //amount

        int ammount = weaponsList.Count;

        //clear 
        weaponsList.Clear();
    }
}

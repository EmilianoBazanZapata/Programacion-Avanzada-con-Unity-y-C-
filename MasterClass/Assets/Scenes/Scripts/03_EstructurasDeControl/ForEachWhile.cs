using System.Collections;
using UnityEngine;

public class ForEachWhile : MonoBehaviour
{
    public int[] weaponAmmoArray;


    private void CheckWeaponAmmo() 
    {
        for (int i = 0; i < weaponAmmoArray.Length; i++)
        {
            Debug.Log($"Indez {i} - Ammo: {weaponAmmoArray[i]}");
        }

        foreach (var weapon in weaponAmmoArray)
        {
            Debug.Log($"Indez ? - Ammo: {weapon}");

        }
    }

    private IEnumerator Fade() 
    {
        float alpha = 1;
        while (alpha > 0)
        {
            alpha -= Time.deltaTime * 1;
            yield return null;  
        }
    }
}

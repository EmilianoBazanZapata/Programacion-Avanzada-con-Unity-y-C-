using System;
using UnityEngine;

public class RangeMin : MonoBehaviour
{
    [Range(1f,100f)]
    public float shootSpeed;
    
    [Range(1, 100)]
    public int sootRate;

    [Min(5.2f)]
    public float bulletSpeed;

    [Min(1)]
    public int bulletsPerShoot;
}

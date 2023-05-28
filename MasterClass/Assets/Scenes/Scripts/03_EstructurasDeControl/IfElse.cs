using UnityEngine;

public class IfElse : MonoBehaviour
{
    public bool canAttack;
    public int currentAmmo;
    public int totalAmmo;
    public SphereCollider shieldColider;

    private void Attack() 
    {
        if (canAttack)
        {
            Debug.Log("Attack!");
        }
        else 
        {
            Debug.Log("I can't attack");
        }

        Debug.Log(canAttack ? "Attack!" : "I can't attack."); //--> operador ternario
    }

    private void CheckAmmo() 
    {
        if (currentAmmo > 0) 
        {
            //Shoot
        }

        if (totalAmmo == 0 || currentAmmo <= 0)
        {
            //Required ammo
        }
    }

    private void Defense() 
    {
        if (shieldColider != null) 
        {
            //Use shield
        }
    }
}

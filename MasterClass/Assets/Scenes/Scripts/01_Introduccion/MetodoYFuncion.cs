using UnityEngine;

public class MetodoYFuncion : MonoBehaviour
{
    int ammo;
    int weapon;
    int myId;

    // Start is called before the first frame update
    private void Start()
    {
        //Shoot(5);
        //Shoot();
        Shoot(weaponType: 2);

        myId = GetPlayerId();

        //cero una copia de la variable y todo lo que modifique no afecta a la variable original
        ChangePlayerIdWithOut(out myId);

        // todo lo que modifique afecta a la variable original
        ChangePlayerIdWithRef(ref myId);
    }

    public void Shoot(int amountBullets = 10, int weaponType = 0)
    {
        ammo = amountBullets;
        weapon = weaponType;    
    }

    private int GetPlayerId() 
    {
        return 12;
    }

    private void ChangePlayerIdWithOut(out int id) 
    {
        id = 15;
    }

    private void ChangePlayerIdWithRef(ref int id)
    {
        id = 10;
    }
}

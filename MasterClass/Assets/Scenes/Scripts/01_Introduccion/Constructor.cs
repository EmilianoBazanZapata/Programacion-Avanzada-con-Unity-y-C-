using UnityEngine;

public class Constructor : MonoBehaviour
{
    private void Start()
    {
        Weapon weapon = new Weapon(100);
        weapon.Shoot();
    }


    public class Weapon
    {
        int ammo;

        public Weapon()
        {
            ammo = 30;
        }

        public Weapon(int ammo)
        {
            this.ammo = ammo;
        }

        public void Shoot() 
        {

        }
    }
}

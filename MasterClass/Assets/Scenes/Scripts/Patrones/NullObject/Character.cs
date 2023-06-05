using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.NullObject
{
    public class Character : MonoBehaviour
    {
        private Weapon currentWeapon;
        private IDamage currentTarget;

        private void Awake()
        {
            currentWeapon = new WeaponNull();
        }

        public void Attack()
        {
            currentWeapon.Attack(currentTarget);
        }
    }
}
using UnityEngine;
using System;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Strategy
{
    public class Character : MonoBehaviour, IDamage
    {
        public GameObject weaponPrefab;
        private IWeapon _weapon;

        private void EquipWeapon()
        {
            _weapon = Instantiate(weaponPrefab,transform).GetComponent<IWeapon>();
        
            if(_weapon == null)
            {
                throw new Exception($"Prefab {weaponPrefab.name} does not implement IWeapon interface");
            }
        }

        public void DoDamage(int damage)
        {
            Debug.Log("Receive Damage", this);
            throw new System.NotImplementedException();
        }
        
        private void Attack()
        {
            _weapon.Attack();
        }
    }
}
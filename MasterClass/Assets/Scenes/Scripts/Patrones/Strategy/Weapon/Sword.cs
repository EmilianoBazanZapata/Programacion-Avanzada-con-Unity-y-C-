using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Strategy.Weapon
{
    public class Sword : MonoBehaviour, IWeapon
    {
        private int _damage = 10;
        private float _attackRadious = 200f;

        public void Attack()
        {
            var hits = Physics2D.OverlapCircleAll(transform.position, _attackRadious);

            if (hits[0] != null)
            {
                for (int i = 0; i < hits.Length; i++)
                {
                    var otherDamage = hits[i].GetComponent<IDamage>();
                    otherDamage?.DoDamage(_damage);
                }
            }
        }
    }
}
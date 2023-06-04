using UnityEngine;

namespace Course.SOLID.After
{
    public class Character : MonoBehaviour, IDamage, IHeal
    {
        public string characterName;

        public void Damage(int value)
        {
            throw new System.NotImplementedException();
        }

        public void Heal(int value)
        {
            throw new System.NotImplementedException();
        }
    }
}

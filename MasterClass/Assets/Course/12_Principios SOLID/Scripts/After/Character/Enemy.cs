using UnityEngine;

namespace Course.SOLID.After
{
    public class Enemy : MonoBehaviour, IDamage
    {
        public void Damage(int value)
        {
            Debug.Log($"Enemy receive {value} damage!");
        }

        private void OnTriggerEnter(Collider other)
        {
            IDamage otherCharacter = other.GetComponent<IDamage>();

            if (otherCharacter != null)
            {
                otherCharacter.Damage(15);
            }
        }

    }
}

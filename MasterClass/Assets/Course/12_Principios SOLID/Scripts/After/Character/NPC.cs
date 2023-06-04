using UnityEngine;

namespace Course.SOLID.After
{
    public class NPC : MonoBehaviour, IInteract
    {
        private IHeal otherCharacter;

        public void Interact()
        {
            if (otherCharacter != null)
            {
                otherCharacter.Heal(500);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            otherCharacter = other.GetComponent<IHeal>();
        }

        private void OnTriggerExit(Collider other)
        {
            otherCharacter = null;
        }
    }
}

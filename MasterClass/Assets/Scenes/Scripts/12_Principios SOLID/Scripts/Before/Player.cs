using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Course.SOLID.Before
{
    public class Player : MonoBehaviour, ICharacter
    {
        public string playerName;
        public int health = 100;
        public float speedMovement = 15f;
        [Space]
        public Item currentItem;
        [Space]
        public TextMeshProUGUI healthTxt;

        private ICharacter otherCharacter;

        private void Start()
        {
            healthTxt.text = "Health: " + health.ToString();
        }

        #region Interface

        public void Damage(int value)
        {
            health = Mathf.Clamp(health - value, 0, 100);

            if (health <= 0)
            {
                Debug.Log("Player DEAD");
            }

            healthTxt.text = "Health: " + health.ToString();
        }

        public void Heal(int value)
        {
            health = Mathf.Clamp(health + value, 0, 100);

            healthTxt.text = "Health: " + health.ToString();
        }

        public void Interact()
        {
            // None
        }

        #endregion

        private void OnTriggerEnter(Collider other)
        {
            otherCharacter = other.GetComponent<ICharacter>();
        }

        private void OnTriggerExit(Collider other)
        {
            otherCharacter = null;
        }

        public void ActionInteraction()
        {
            if (otherCharacter != null)
            {
                otherCharacter.Interact();
            }
        }

        public void ActionConsumeItem()
        {
            if (currentItem != null)
            {
                if (currentItem is ItemWeapon)
                {
                    Debug.Log($"{currentItem.itemName}: Shoot!");
                }
                else if (currentItem is ItemPotion)
                {
                    Debug.Log($"{currentItem.itemName}: Drink to get more power!");
                }
            }
        }
    }
}
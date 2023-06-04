using UnityEngine;
using UnityEngine.Events;

namespace Course.SOLID.After
{
    public class PlayerInput : MonoBehaviour
    {
        public InputHandler inputHandler;
        [Space]
        public float speedMovement = 15f;
        [Space]
        public UnityEvent onInteract;
        public UnityEvent onConsumeItem;

        private void Update()
        {
            ActionMovement();

            ActionInteraction();

            ActiionConsumeItem();
        }

        private void ActionMovement()
        {
            // Movement
            float inputHorizontal = inputHandler.GetAxistHorizontal();

            Vector3 direction = new Vector3(inputHorizontal, 0, 0);

            transform.Translate(direction * speedMovement * Time.deltaTime);
        }

        private void ActionInteraction()
        {
            // Interaction
            if (Input.GetKeyDown(KeyCode.E))
            {
                onInteract.Invoke();
            }
        }

        private void ActiionConsumeItem()
        {
            // Consume Item
            if (Input.GetKeyDown(KeyCode.Space))
            {
               onConsumeItem.Invoke();
            }
        }
    }
}
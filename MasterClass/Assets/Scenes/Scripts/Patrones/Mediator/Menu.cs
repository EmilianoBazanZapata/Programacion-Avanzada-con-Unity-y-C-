using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Mediator
{
    public class Menu : MonoBehaviour
    {
        public MenuMediator mediator;

        public abstract void Show();
        public abstract void Hide();
    }
}
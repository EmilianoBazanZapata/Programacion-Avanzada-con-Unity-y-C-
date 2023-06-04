using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Mediator
{
    public abstract class Menu : MonoBehaviour
    {
        public MenuMediator mediator;

        public abstract void Show();
        public abstract void Hide();
    }
}

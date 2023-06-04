using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Mediator
{
    public class MenuMediator : MonoBehaviour
    {
        public Menu[] menus;
        // 0 - MainMenu
        // 1 - Play
        // 2 - Settings
        // 3 - Exit

        public int currentIndex = 0;
        public int latsIndex = 0;

        private void ChangeMenu(int index)
        {
            currentIndex = index;

            menus[latsIndex].Hide();
            menus[currentIndex].Show();

            latsIndex = currentIndex;
        }

        public void GoToMainMenu()
        {
            ChangeMenu(0);
        }

        public void GoToPlay()
        {
            ChangeMenu(1);
        }

        public void GoToSettings()
        {
            ChangeMenu(2);
        }

        public void GoToExit()
        {
            ChangeMenu(3);
        }
    }
}
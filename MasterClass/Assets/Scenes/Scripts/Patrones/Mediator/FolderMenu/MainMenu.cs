using UnityEngine.UI;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Mediator.Menu
{
    public class MainMenu : Menu
    {
        public Button playBtn;
        public Button settingsBtn;
        public Button exitBtn;

        public override void Show() { } 
        public override void Hide() { }

        private void Start()
        {
            playBtn.onClick.AddListener(() => mediator.GoToPlay());
            settingsBtn.onClick.AddListener(() => mediator.GoTOSettings());
            exitBtn.onClick.AddListener(() => mediator.GoToExit());
        }
    }
}
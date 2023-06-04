using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.ServiceLocator
{
    public class GameServiceInstaller : MonoBehaviour
    {
        public PlayerPrefsAdapter saveSystem;

        private void Awake()
        {
            GameServiceLocator.Instance.RegisterService<IDataSaver>(saveSystem);
        }
    }
}
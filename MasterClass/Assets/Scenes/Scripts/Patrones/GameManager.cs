using MasterClass.Assets.Scenes.Scripts.Patrones.ServiceLocator;
using MasterClass.Assets.Scenes.Scripts.Patrones.Singleton;
using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Adapter
{
    public class GameManager : MonoBehaviour
    {
        private SaveSystem saveSystem;
        private IDataSaver dataSaver;

        private void Start()
        {
            saveSystem = new SaveSystem(new PlayerPrefsAdapter());

            MasterClass.Assets.Scenes.Scripts.Patrones.Singleton.PlayerPrefsSingleton.Instance.GetInt("asdf", 12);
            dataSaver = GameServiceLocator.Instance.GetService<IDataSaver>();
            dataSaver.GetInt("asdf", 12);
        }
    }
}
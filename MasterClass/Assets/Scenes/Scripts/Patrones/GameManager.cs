using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Adapter
{
    public class GameManager : MonoBehaviour
    {
        private SaveSystem saveSystem;

        private void Start()
        {
            saveSystem = new SaveSystem( new PlayerPrefsAdapter());
        }
    }
}
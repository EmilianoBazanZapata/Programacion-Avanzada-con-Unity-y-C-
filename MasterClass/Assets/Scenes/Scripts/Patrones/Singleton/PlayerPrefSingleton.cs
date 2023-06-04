using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Singleton
{
    public class PlayerPrefsSingleton : MonoBehaviour, IDataSaver
    {
        #region Singleton
        private static PlayerPrefsSingleton _instance;
        public static PlayerPrefsSingleton Instance
        {
            get
            {
                if (!_instance)
                {
                    Debug.LogWarningFormat("Acceaing {0} before its Awake phase", typeof(PlayerPrefsSingleton).Name);
                }
                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance != null && _instance != this || FindObjectsOfType<PlayerPrefsSingleton>().Length > 1)
            {
                Debug.LogWarningFormat("Please make sure there is only one {0} in the scene", typeof(PlayerPrefsSingleton).Name);
                Destroy(this);
                return;
            }
            else
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        #endregion

        public void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }
        public string GetString(string key, string defaultValue = "None")
        {
            return PlayerPrefs.GetString(key, defaultValue);
        }

        public void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
            PlayerPrefs.Save();
        }
        public int GetInt(string key, int defaultValue = 0)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
        }
    }
}
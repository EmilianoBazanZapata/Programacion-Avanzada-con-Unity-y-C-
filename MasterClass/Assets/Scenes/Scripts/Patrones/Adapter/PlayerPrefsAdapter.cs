using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Adapter
{
    public class PlayerPrefsAdapter : IDataSaver
    {
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
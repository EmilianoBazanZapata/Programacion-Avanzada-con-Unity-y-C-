using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.ServiceLocator
{
    public interface IDataSaver
    {
        void SetString(string key, string value);
        string GetString(string key, string defaultValue);
        void SetInt(string key, int value);
        int GetInt(string key, int defaultValue);
    }
}
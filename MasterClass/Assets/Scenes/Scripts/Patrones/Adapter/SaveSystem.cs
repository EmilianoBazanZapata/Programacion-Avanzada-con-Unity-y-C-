namespace MasterClass.Assets.Scenes.Scripts.Patrones.Adapter
{
    public class SaveSystem : IDataSaver
    {
        private readonly IDataSaver _dataSaver;
        public SaveSystem(IDataSaver dataSaver)
        {
            _dataSaver = dataSaver;
        }

        public void SetString(string key, string value)
        {
            _dataSaver.SetString(key, value);
        }
        public string GetString(string key, string defaultValue)
        {
            return _dataSaver.GetString(key, defaultValue);
        }

        public void SetInt(string key, int value)
        {
            _dataSaver.SetInt(key, value);
        }
        public int GetInt(string key, int defaultValue)
        {
            return _dataSaver.GetInt(key, defaultValue);
        }
    }
}
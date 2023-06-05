using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Factory
{
    [CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/Data/Item", order = 0)]
    public class ItemSO : DataSO
    {
        public Sprite sprite;
        public string title;
        public float price;
    }
}
using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Strategy.Weapon
{
    public class Bow : MonoBehaviour, IWeapon
    {
        public GameObject arrowPrefab;
        public Transform spawnTransform;
        public void Attack()
        {
            Instantiate(arrowPrefab, spawnTransform.position, spawnTransform.rotation);
        }
    }
}
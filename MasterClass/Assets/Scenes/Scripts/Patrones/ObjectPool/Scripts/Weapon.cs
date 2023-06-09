using UnityEngine;
using UnityEngine.Pool;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.ObjectPool.Scripts
{
    public class Weapon : MonoBehaviour
    {
        public Bullet bulletPrefab;
        public int spawAmount = 30;

        [Header("Object Pool")]
        public bool usePool;
        public IObjectPool<Bullet> pool;
        public bool collectionChecks = false;
        public int defaultCapacity = 100;
        public int maxCapacity = 1000;

        private void Start()
        {
            if (usePool)
            {
                pool = new ObjectPool<Bullet>(CreatePooledItem,
                                              OnTakeToPool,
                                              OnReturnedToPool,
                                              OnDestroyPoolObject,
                                              collectionChecks,
                                              defaultCapacity,
                                              maxCapacity);
            }

            InvokeRepeating(nameof(Spawn), .2f, .2f);
        }

        #region Object Pool

        private Bullet CreatePooledItem()
        {
            return Instantiate(bulletPrefab);
        }

        private void OnReturnedToPool(Bullet obj)
        {
            obj.gameObject.SetActive(false);
        }

        private void OnTakeToPool(Bullet obj)
        {
            obj.gameObject.SetActive(true);
        }

        private void OnDestroyPoolObject(Bullet obj)
        {
            Destroy(obj.gameObject);
        }

        #endregion

        private void Spawn()
        {
            for (int i = 0; i < spawAmount; i++)
            {
                var bullet = usePool ? pool.Get() : Instantiate(bulletPrefab);
                bullet.transform.position = transform.position + Random.insideUnitSphere * 3;
                bullet.Init(Kill);
            }
        }

        private void Kill(Bullet bullet)
        {
            if (usePool)
            {
                pool.Release(bullet);
            }
            else
            {
                Destroy(bullet.gameObject);
            }
        }
    }
}
using Script.ECS;
using Script.Modules;
using UnityEngine;
using System.Collections.Generic;

namespace Script.Updaters
{
    public class SpawnUpdater : IUpdater
    {
        private static ShotUpdaterType1 _singleton;
        public static ShotUpdaterType1 Instance()
        {
            return _singleton ??= new ShotUpdaterType1();
        }

        List<PoolableObject> Objects;
        PoolManager poolManager;

        public void start()
        {
            Objects = new List<PoolableObject>();
            poolManager = PoolManager.Instance();
        }


        public void SystemUpdate()
        {
            var SpawnAccessor = TAccessor<SpawnModule>.Instance();

            Debug.Log("braa");

            foreach (var module in SpawnAccessor.GetAllModules())
            {
                var entity = module.gameObject;
                var currentMod = SpawnAccessor.TryGetModule(entity);

                if (currentMod != null)
                {
                    PoolableObject ennemy = poolManager.GetPooledObject(objectType.ennemy);



                    // Initialize and set active all instancied ennemy in the ennemy pool 
                    if (ennemy != null)
                    {
                        ennemy.Init();
                        Objects.Add(ennemy);

                        ennemy.transform.position = new Vector3(Random.Range(-5.0f, 5.0f), 0, Random.Range(-5.0f, 5.0f));

                    }
                }
            }
        }
    }
}
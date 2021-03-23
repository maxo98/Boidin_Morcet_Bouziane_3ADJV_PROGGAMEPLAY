using Script.ECS;
using Script.Modules;
using UnityEngine;
using System.Collections.Generic;

namespace Script.Updaters
{
    public class SpawnUpdater : IUpdater
    {
        private static SpawnUpdater _singleton;
        public static SpawnUpdater Instance()
        {
            return _singleton ??= new SpawnUpdater();
        }

        private readonly List<PoolableObject> _objects = new List<PoolableObject>();
        
        public void SystemUpdate()
        {
            var  poolManager = PoolManager.Instance();
            var spawnAccessor = TAccessor<SpawnModule>.Instance();
            
            foreach (var module in spawnAccessor.GetAllModules())
            {
                PoolableObject ennemy = poolManager.GetPooledObject(objectType.ennemy);
                
                if (ennemy != null)
                {
                    ennemy.Init();
                    _objects.Add(ennemy);

                    ennemy.transform.position = new Vector3(Random.Range(-5.0f, 5.0f), 0, Random.Range(-5.0f, 5.0f));
                }
                
            }
        }
    }
}
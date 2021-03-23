using Script.ECS;
using Script.Modules;
using UnityEngine;
using System.Collections.Generic;
using System.Xml;

namespace Script.Updaters
{
    public class SpawnUpdater : IUpdater
    {
        private float _timeRemaining = 20;
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
                if (_timeRemaining > 0)
                {
                    _timeRemaining -= Time.deltaTime;

                }
                else
                {
                    _timeRemaining = 20;
                    PoolableObject ennemy = poolManager.GetPooledObject(objectType.ennemy);

                    if (ennemy != null)
                    {
                        ennemy.Init(new Vector3(Random.Range(-5.0f, 5.0f), 0, Random.Range(-5.0f, 5.0f)));
                        _objects.Add(ennemy);
                    }
                }
            }
        }
    }
}
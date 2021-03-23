using System.Collections.Generic;
using Script.ECS;
using Script.Modules;
using UnityEngine;

namespace Script.Updaters
{
    public class PlayerColliderUpdater : IUpdater
    {
        private static PlayerColliderUpdater _singleton; 
        public static PlayerColliderUpdater Instance()
        {
            return _singleton ??= new PlayerColliderUpdater();
        }
        
        private readonly List<PoolableObject> _objects = new List<PoolableObject>();
        
        public void SystemUpdate()
        {
            var playerColliderAccessor = TAccessor<ColliderModule>.Instance();
            var poolManager = PoolManager.Instance();
            var allModules = playerColliderAccessor.GetAllModules();
            foreach (var module in allModules)
            {
                var entity = module.gameObject;
                if (entity.CompareTag("Player"))
                {
                    foreach (var mod in allModules)
                    {
                        if (!mod.gameObject.CompareTag("Player") &&
                            ((mod.Position.position.x - module.Position.position.x) < 2 ||
                             (mod.Position.position.y - module.Position.position.y) < 2))
                        {
                            poolManager.ReleasePooledObject(mod.gameObject.GetComponent<PoolableObject>());
                        }
                    }
                }
            }
        }
    }
}
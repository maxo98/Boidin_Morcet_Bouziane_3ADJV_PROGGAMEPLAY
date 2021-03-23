using Script.ECS;
using Script.Modules;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Updaters
{
    public class MovementUpdaterPlayerShot : IUpdater
    {
        private static MovementUpdaterPlayerShot _singleton;
        public static MovementUpdaterPlayerShot Instance()
        {
            return _singleton ??= new MovementUpdaterPlayerShot();
        }
        private readonly List<PoolableObject> _objects = new List<PoolableObject>();
        public void SystemUpdate()
        {
            var poolManager = PoolManager.Instance();
            var playerShotAccessor = TAccessor<PlayerShotModule>.Instance();

            foreach (var module in playerShotAccessor.GetAllModules())
            {
                var entity = module.gameObject;
                var currentMod = playerShotAccessor.TryGetModule(entity);

                if (currentMod != null)
                {
                    if (Input.GetKeyDown(currentMod.Key))
                    {
                        PoolableObject bullet = poolManager.GetPooledObject(objectType.bullet);

                        // Initialize and set active all instancied bullet in the bullet pool 
                        if (bullet != null)
                        {
                            bullet.Init(entity.transform.position);
                            _objects.Add(bullet);
                            

                        }
                    }
                }
            }
        }
    }
}
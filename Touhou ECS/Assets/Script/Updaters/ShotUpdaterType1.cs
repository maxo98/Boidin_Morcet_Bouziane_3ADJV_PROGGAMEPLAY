using Script.ECS;
using Script.Modules;
using UnityEngine;
using System.Collections.Generic;

namespace Script.Updaters
{
    
    public class ShotUpdaterType1 : IUpdater
    {
        private static ShotUpdaterType1 _singleton; 
        public static ShotUpdaterType1 Instance()
        {
            return _singleton ??= new ShotUpdaterType1();
        }

        private readonly List<PoolableObject> _objects = new List<PoolableObject>();
            
        public new void SystemUpdate()
        {
            var poolManager = PoolManager.Instance();
            var cooldownAccessor = TAccessor<CooldownModule>.Instance();
            foreach (var module in cooldownAccessor.GetAllModules())
            {
                var entity = module.gameObject;

                if (module != null)
                {

                    if (module.ResetCooldown <= 0)
                    {
                        Debug.Log("Pan !");
                        module.ResetCooldown = module.Cooldown;
                        PoolableObject bullet = poolManager.GetPooledObject(objectType.bullet);

                        // Initialize and set active all instancied bullet in the bullet pool 
                        if (bullet != null)
                        {
                            bullet.Init();
                            _objects.Add(bullet);

                        }
                    }
                    else
                    {
                        module.ResetCooldown -= Time.deltaTime;
                    }
                }
            }
        } 
    }
}

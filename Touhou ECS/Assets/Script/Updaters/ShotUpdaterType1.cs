using Script.ECS;
using Script.Modules;
using UnityEngine;
using System.Collections.Generic;

namespace Script.Updaters
{
    public class ShotUpdaterType1 : IUpdater
    {
        List<PoolableObject> Objects;
        PoolManager poolManager;
        void Start()
        {
            // Objects contient l'ensemble des objets instanciés et actif sur la scène
            Objects = new List<PoolableObject>();
            poolManager = PoolManager.Instance();
        }
        public void SystemUpdate()
        {
            var speedAccessor = TAccessor<SpeedModule>.Instance();
            var cooldownAccessor = TAccessor<CooldownModule>.Instance();

            foreach (var module in speedAccessor.GetAllModules())
            {
                var entity = module.gameObject;
                var currentMod = speedAccessor.TryGetModule(entity);
                var otherMod = cooldownAccessor.TryGetModule(entity);

                if (currentMod != null && otherMod != null)
                {
                    if (otherMod.Cooldown <= 0)
                    {
                        Debug.Log("Pan !");
                        PoolableObject bullet = poolManager.GetPooledObject(objectType.bullet);

                        // Initialize and set active all instancied bullet in the bullet pool 
                        if (bullet != null)
                        {
                            bullet.Init();
                            Objects.Add(bullet);

                        }
                    }
                    else
                    {
                        otherMod.Cooldown -= Time.deltaTime;
                    }
                }
            }
        } 
    }
}

using Script.ECS;
using Script.Modules;
using UnityEngine;

namespace Script.Updaters
{
    public class ShotUpdaterType1 : IUpdater
    {
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
                        // on fait spawn un projectil
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

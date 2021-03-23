using Script.ECS;
using UnityEngine;

namespace Script
{
    public class MovementUpdaterEnemy1 : IUpdater
    {
        public void SystemUpdate()
        {
            var playerAccessor = TAccessor<SpeedModule>.Instance();

            foreach (var module in playerAccessor.GetAllModules())
            {
                var entity = module.gameObject;
                var currentMod = playerAccessor.TryGetModule(entity);

                if (currentMod != null)
                {
                    entity.transform.position = entity.transform.forward * Time.deltaTime * currentMod.Speed;
                }
            }
        }
    }
}
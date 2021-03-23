using Script.ECS;
using Script.Modules;
using UnityEngine;

namespace Script.Updaters
{
    public class MovementUpdaterZigZag : IUpdater
    {
        public void SystemUpdate()
        {
            var zigzagAccessor = TAccessor<ZigZagModule>.Instance();
            var speedAccessor = TAccessor<SpeedModule>.Instance();

            foreach (var module in zigzagAccessor.GetAllModules())
            {
                var entity = module.gameObject;
                var currentMod = zigzagAccessor.TryGetModule(entity);
                var otherMod = speedAccessor.TryGetModule(entity);

                if (otherMod != null && currentMod != null)
                {
                    entity.transform.position += entity.transform.forward* Time.deltaTime * otherMod.Speed + entity.transform.right * Mathf.Sin(Time.time * currentMod.Frequency) * currentMod.Magnitude;
                }
            }
        }
    }
}


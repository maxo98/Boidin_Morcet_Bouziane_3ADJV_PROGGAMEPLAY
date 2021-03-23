using Script.ECS;
using Script.Modules;
using UnityEngine;

namespace Script.Updaters
{
    public class MovementUpdaterZigZag : IUpdater
    {
        private static MovementUpdaterZigZag _singleton;
        public static MovementUpdaterZigZag Instance()
        {
            return _singleton ??= new MovementUpdaterZigZag();
        }
        public void SystemUpdate()
        {
            var zigzagAccessor = TAccessor<ZigZagModule>.Instance();


            foreach (var module in zigzagAccessor.GetAllModules())
            {
                var entity = module.gameObject;
                var currentMod = zigzagAccessor.TryGetModule(entity);

                if (currentMod != null)
                {
                    entity.transform.position -= entity.transform.forward* Time.deltaTime * currentMod.Speed + entity.transform.right * Mathf.Sin(Time.time * currentMod.Frequency) * currentMod.Magnitude;
                }
            }
        }
    }
}


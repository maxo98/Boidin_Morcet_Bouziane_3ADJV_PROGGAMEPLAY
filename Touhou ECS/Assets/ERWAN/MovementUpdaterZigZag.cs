using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUpdaterZigZag : IUpdater
{
    public void SystemUpdate()
    {
        var zigzagAccessor = TAccessor<ZigZagModule>.Instance();
        var speedAccessor = TAccessor<SpeedModule>.Instance();

        foreach (var module in zigzagAccessor.GetAllModules())
        {
            var entity = module.gameObject;
            var otherMod = speedAccessor.TryGetModule(entity);

            if (otherMod != null)
            {
                entity.transform.position += entity.transform.forward* Time.deltaTime * otherMod.Speed + entity.transform.right * Mathf.Sin(Time.time * module.Frequency) * module.Magnitude;
            }
        }
    }
}


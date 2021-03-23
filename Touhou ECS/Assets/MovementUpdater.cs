using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUpdaterType1 : IUpdater
{
    public void SystemUpdate()
    {
        var speedAccessor = TAccessor<SpeedModule>.Instance();

        foreach (var module in speedAccessor.GetAllModules())
        {
            var entity = module.gameObject;
            var currentMod = speedAccessor.TryGetModule(entity);

            if (currentMod != null)
            {
                //implement movement logic
            }
        }
    }
}
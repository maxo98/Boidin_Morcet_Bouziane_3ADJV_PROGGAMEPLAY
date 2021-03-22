using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUpdater : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<ModuleType1> accessorType1 = TAccessor<ModuleType1>.Instance();
        TAccessor<ModuleType2> accessorType2 = TAccessor<ModuleType2>.Instance();
        TAccessor<ModuleType3> accessorTyp3 = TAccessor<ModuleType3>.Instance();
        TAccessor<ModuleType4> accessorType4 = TAccessor<ModuleType4>.Instance();
        TAccessor<ModulePlayer> accessorPlayer = TAccessor<ModulePlayer>.Instance();
        foreach (var module in accessorType1.GetAllModules())
        {
            GameObject entity = module.Value.GameObject;
            var currentMod = accessorType1.TryGetModule(entity);

            if (currentMod != null)
            {
                //implement movement logic
            }
        }
    }
}
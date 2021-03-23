﻿using Script.ECS;
using Script.Modules;
using UnityEngine;

namespace Script.Updaters
{
    public class MovementUpdaterPlayer : IUpdater
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
                    Vector3 _move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
                    entity.transform.position += _move * Time.deltaTime * currentMod.Speed;
                }
            }
        }
    }
}
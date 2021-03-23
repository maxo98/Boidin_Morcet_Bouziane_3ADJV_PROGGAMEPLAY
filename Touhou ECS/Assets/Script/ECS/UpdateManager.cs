using System;
using Script.Updaters;
using UnityEngine;

namespace Script.ECS
{
    public class UpdateManager : MonoBehaviour
    {
        
        private void Update()
        {
            ShotUpdaterType1.Instance().SystemUpdate();
            MovementUpdaterEnemy1.Instance().SystemUpdate();
            SpawnUpdater.Instance().SystemUpdate();
        }
    }
}
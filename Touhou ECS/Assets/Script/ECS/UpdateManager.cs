using System;
using UnityEngine;

namespace Script.ECS
{
    public class UpdateManager : MonoBehaviour
    {
        private readonly IUpdater _updater = IUpdater.Instance();

        private void Start()
        {
            _updater.SystemInit(FindObjectsOfType<TModule>());
        }

        private void Update()
        {
            
        }
    }
}
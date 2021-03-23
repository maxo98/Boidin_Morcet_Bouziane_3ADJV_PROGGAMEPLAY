using System;
using UnityEngine;
namespace Script.Modules
{
    public class SpawnModule : TModule
    {
        
        [SerializeField] private float spawnRate;

        private void Awake()
        {
            TAccessor<SpawnModule>.Instance().Add(this);
        }
        public float SpawnRate
        {
            get => spawnRate;
            set => spawnRate = value;
        }

    }
}

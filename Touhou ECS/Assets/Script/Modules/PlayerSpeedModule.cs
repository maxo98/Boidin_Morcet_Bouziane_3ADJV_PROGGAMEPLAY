using UnityEngine;

namespace Script.Modules

{
    public class PlayerSpeedModule : TModule
    {
        [SerializeField] private float playerSpeed = 5;

        private void Awake()
        {
            TAccessor<PlayerSpeedModule>.Instance().Add(this);
        }

        public float PlayerSpeed
        {
            get => playerSpeed;
            set => playerSpeed = value;
        }
    }
}
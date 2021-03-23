using UnityEngine;

namespace Script.Modules

{
    public class CooldownModule: TModule
    {
        [SerializeField] private float cooldown;
        private float resetCooldown = 1;
        
        private void Awake()
        {
            TAccessor<CooldownModule>.Instance().Add(this);
        }
        
        public float Cooldown
        {
            get => cooldown;
            set => cooldown = value;
        }

        public float ResetCooldown
        {
            get => resetCooldown;
            set => resetCooldown = value;
        }
    }
}
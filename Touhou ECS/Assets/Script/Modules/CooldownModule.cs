using UnityEngine;

namespace Script.Modules

{
    public class CooldownModule: TModule
    {
        [SerializeField] private float cooldown;
        
        private void Awake()
        {
            TAccessor<CooldownModule>.Instance().Add(this);
        }
        
        public float Cooldown
        {
            get => cooldown;
            set => cooldown = value;
        }
    }
}
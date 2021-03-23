using UnityEngine;

namespace Script.Modules

{
    public class CooldownModule: TModule
    {
        [SerializeField] private float cooldown;

        public float Cooldown
        {
            get => cooldown;
            set => cooldown = value;
        }
    }
}
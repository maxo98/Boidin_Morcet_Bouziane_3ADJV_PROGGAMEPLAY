using UnityEngine;

namespace Script.Modules

{
    public class PlayerShotModule : TModule
    {
        [SerializeField] private KeyCode key = KeyCode.Space;

        private void Awake()
        {
            TAccessor<PlayerShotModule>.Instance().Add(this);
        }

        public KeyCode Key
        {
            get => key;
            set => key = value;
        }
    }
}
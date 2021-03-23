using UnityEngine;

namespace Script.Modules
{
    public class ZigZagModule : TModule
    {
        [SerializeField] private float magnitude;
        [SerializeField] private float frequency;
        [SerializeField] private float speed;

        private void Awake()
        {
            TAccessor<ZigZagModule>.Instance().Add(this);
        }

        public float Magnitude
        {
            get => magnitude;
            set => magnitude = value;
        }

        public float Frequency
        {
            get => frequency;
            set => frequency = value;
        } 
        public float Speed
        {
            get => speed;
            set => speed = value;
        }
    }
}

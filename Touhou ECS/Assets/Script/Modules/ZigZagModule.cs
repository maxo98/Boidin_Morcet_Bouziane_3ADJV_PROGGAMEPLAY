using UnityEngine;

namespace Script.Modules
{
    public class ZigZagModule : MonoBehaviour
    {
        [SerializeField] private float magnitude;
        [SerializeField] private float frequency;


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
    }
}

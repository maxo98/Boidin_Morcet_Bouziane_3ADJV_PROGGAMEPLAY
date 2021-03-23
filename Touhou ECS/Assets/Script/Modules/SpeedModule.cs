using UnityEngine;
namespace Script.Modules
{
    public class SpeedModule : TModule
    {
        [SerializeField] private float speed;


        public float Speed
        {
            get => speed;
            set => speed = value;
        }

    }
}
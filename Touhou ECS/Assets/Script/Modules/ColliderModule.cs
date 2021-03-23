using UnityEngine;

namespace Script.Modules
{
    public class ColliderModule : TModule
    {
        [SerializeField]
        private Transform position;

        public Transform Position
        {
            get => position;
            set => position = value;
        }
        
    }
}
using Script.ECS;
using Script.Modules;
using UnityEngine;


namespace Script.Updaters
{
    public class MovementUpdaterEnemy1 : IUpdater
    {
        private static MovementUpdaterEnemy1 _singleton;
        public static MovementUpdaterEnemy1 Instance()
        {
            return _singleton ??= new MovementUpdaterEnemy1();
        }


        public new void SystemUpdate()
        {
            var speedAccessor = TAccessor<SpeedModule>.Instance();

            foreach (var module in speedAccessor.GetAllModules())
            {
                Debug.Log("J'AVANCErrrr");
                var entity = module.gameObject;
                entity.transform.position -= entity.transform.forward * (Time.deltaTime * module.Speed);
            }
        }
    }
}
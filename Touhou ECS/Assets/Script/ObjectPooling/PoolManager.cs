using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;

[Serializable]
public struct ObjectForPool
{
    public objectType ObjectType;
    public PoolableObject Prefab;
    public int Number;
}

public class PoolManager : MonoBehaviour
{
   
    static public PoolManager Instance() { return _singleton; }
    static private PoolManager _singleton;
   
   

    private void Awake()
    {
        _singleton = this;
        Initialize();
    }
    
    // ObjectPrefab take all type of object that can be use to create a pool
    public List<ObjectForPool> ObjectPrefab;
    Dictionary<objectType, Pool> Pools;
    
    // Create a pool of the chosen type and add instances of an object to it
    public void Initialize()
    {
        Pools = new Dictionary<objectType, Pool>();
        foreach (ObjectForPool obj in ObjectPrefab)
        {
            
            Pool newPool = new Pool();
            newPool.Initialize(obj.Prefab, obj.Number);
            Pools.Add(obj.ObjectType, newPool);
        }
    }

    // get an inactive object of type from a pool
    public PoolableObject GetPooledObject(objectType parObjectType)
    {
       
        return Pools[parObjectType].PullObject();
    }

    // release an active object 
    public void ReleasePooledObject(PoolableObject parObject)
    {
        parObject.DeInit();
    }

}

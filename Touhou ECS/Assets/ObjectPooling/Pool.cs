using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum objectType
{
    ennemy,
    bullet
}
public class Pool
{
    

    List<PoolableObject> ObjectInPool;
    
    public void Initialize(PoolableObject parPrefabObect , int parNumber)
    {
        ObjectInPool = new List<PoolableObject>();
        for(int i=0; i< parNumber; ++i)
        {
            PoolableObject go = MonoBehaviour.Instantiate(parPrefabObect);
            go.DeInit();
            ObjectInPool.Add(go);
        }
        
    }

  public PoolableObject PullObject()
    {
        int numberObjectInPool = ObjectInPool.Count;
        for (int i =0; i<numberObjectInPool;++i)
        {
            if (!ObjectInPool[i].isActive())
            {
                return ObjectInPool[i];
            }
        }
        return null;
    }
}

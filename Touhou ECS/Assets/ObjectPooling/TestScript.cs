using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    
    List<PoolableObject> Objects;
    PoolManager poolManager;
    void Start()
    {
        // Objects contient l'ensemble des objets instanciés et actif sur la scène
        Objects = new List<PoolableObject>();
        poolManager = PoolManager.Instance();
    }
    private void Update()
    {        
        PoolableObject ennemy = poolManager.GetPooledObject(objectType.ennemy);
        int objectCount = Objects.Count;

        // Initialize and set active all instancied ennemy in the ennemy pool 
        if (ennemy != null)
        {
            ennemy.Init();
            Objects.Add(ennemy);
            
        }

        PoolableObject bullet = poolManager.GetPooledObject(objectType.bullet);

        // Initialize and set active all instancied bullet in the bullet pool 
        if (bullet != null)
        {
            bullet.Init();
            Objects.Add(bullet);
            
        }

        // Désactive/release tout les objets dans la liste Objects
        /*for (int i = 0; i < objectCount; ++i)
        {
            if (Objects[i] != null)
            {
                poolManager.ReleasePooledObject(Objects[i]);
                
            }
        }*/
    }


}

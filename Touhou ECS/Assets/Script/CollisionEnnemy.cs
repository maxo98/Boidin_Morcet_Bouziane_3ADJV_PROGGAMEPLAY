using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnnemy : MonoBehaviour
{
    List<PoolableObject> Objects;
    PoolManager poolManager;
    // Start is called before the first frame update
    void Start()
    {
        Objects = new List<PoolableObject>();
        poolManager = PoolManager.Instance();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bra");
        poolManager.ReleasePooledObject(other.gameObject.GetComponent<PoolableObject>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

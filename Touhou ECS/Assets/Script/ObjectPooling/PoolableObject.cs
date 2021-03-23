using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableObject : MonoBehaviour
{
    public bool isActive()
    {
        return gameObject.activeInHierarchy;
    }

    public void Init(Vector3 position)
    {
        gameObject.SetActive(true);
        gameObject.transform.position = position;
    }
    public void DeInit()
    {
        gameObject.SetActive(false);
    }

}

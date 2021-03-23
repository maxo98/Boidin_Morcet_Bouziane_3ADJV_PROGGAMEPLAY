using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableObject : MonoBehaviour
{
    public bool isActive()
    {
        return gameObject.activeInHierarchy;
    }
    public void Init()
    {
        gameObject.SetActive(true);
    }
    public void DeInit()
    {
        gameObject.SetActive(false);
    }

}

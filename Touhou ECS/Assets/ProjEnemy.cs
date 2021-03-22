using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjEnemy : MonoBehaviour
{
    public float speed = -4f;
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}

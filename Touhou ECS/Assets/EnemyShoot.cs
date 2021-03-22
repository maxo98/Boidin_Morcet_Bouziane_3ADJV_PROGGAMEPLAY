using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    Transform target;
    Vector3 aimAt;
    public GameObject proj;

    private void Start()
    {
        target = FindObjectOfType<CharacterMovement>().transform;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        aimAt = target.position;
        //Change ici pour pooling
        Instantiate(proj, transform.position, transform.rotation);
    }

}

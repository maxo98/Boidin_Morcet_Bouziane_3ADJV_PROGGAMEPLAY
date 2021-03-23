using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZigZac : MonoBehaviour
{
    public float frequency { get; set; }
    public Transform target { get; set; }
    public float speed { get; set; }
    public float magnitude { get; set; }

    private void Start()
    {
        target = FindObjectOfType<CharacterMovement>().transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime) + transform.right * Mathf.Sin(Time.time * frequency) * magnitude;
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player" )
    //    {
    //        OnRemetDansLePool();
    //    }
    //}

    //public void OnRemetDansLePool()
    //{
    //    Destroy(gameObject);
    //}
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    internal void Move(Vector3 _move)
    {
        transform.position += _move * Time.deltaTime * moveSpeed;
    }

}

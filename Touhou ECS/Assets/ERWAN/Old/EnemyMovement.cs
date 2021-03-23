using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    public enum EnemyType { Front, ZigZag, Spiral };
    public EnemyType mytype;


    public void EnemyMove(EnemyType _myType)
    {
        switch (_myType)
        {
            case EnemyType.Front:
                break;
            case EnemyType.ZigZag:
                break;
            case EnemyType.Spiral:
                break;
            default:
                break;
        }
    }
}

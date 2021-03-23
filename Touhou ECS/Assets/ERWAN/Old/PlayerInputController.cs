using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class PlayerInputController : MonoBehaviour
{

    private CharacterMovement characterMovement;
    
    private void Awake()
    {
        characterMovement = GetComponent<CharacterMovement>();
    }

    private void Update()
    {
        Vector3 _move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        characterMovement.Move(_move);

    }
}

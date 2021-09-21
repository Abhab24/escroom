using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
#pragma warning disable 649

    [SerializeField] Movement movement;
    [SerializeField] MouseLook mouseLook;


    PlayerControls controls;
    PlayerControls.GroundMovementActions GroundMovement;

    Vector2 horizontalInput;
    Vector2 mouseInput;



    private void Awake()
    {
        controls = new Playercontrols();
        GroundMovement = controls.GroundMovement;

        // groundMovement.[action].performed += context => do something
        GroundMovement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();

        GroundMovement.Jump.performed += _ => movement.OnJumpPressed();

        GroundMovement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        GroundMovement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();


    }

    private void Update()
    {
        movement.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }


    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDestroy()
    {
        controls.Disable();
    }
}
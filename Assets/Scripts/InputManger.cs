using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManger : MonoBehaviour
{
    PlayerActions playerController;
    public Vector2 movementInput; // (x,y)
    

    public float verticalInput;
    public float horizontalInput;

    // camera 
    public Vector2 cameraInput; //(x,y)

    public float verticalCamera; //y
    public float horizontalCamera; //x

    private void OnEnable()
    {
        if(playerController== null)
        {
            playerController = new PlayerActions();

            // asingar el valor de Run a nuestra variable 
            playerController.TheaMain.Run.performed += i => movementInput = i.ReadValue<Vector2>();
            // asignar el valor de Camera (mouse) a nuestra variable
            playerController.TheaMain.Camera.performed += i => cameraInput = i.ReadValue<Vector2>(); 
        }

        playerController.Enable();

    }

    private void OnDisable()
    {
        playerController.Disable();
    }

    private void Update()
    {
        HandleMovementInput();
    }

    public void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;

        // camera 
        verticalCamera = cameraInput.y;
        horizontalCamera = cameraInput.x; 

    }



}

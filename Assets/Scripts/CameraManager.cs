using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public InputManger inputManger;

    public Transform playerTransform;
    public Vector3 followVelocity = Vector3.zero;
    public float followSpeed = 0.5f;

    // camera

    public float lookAngleY;
    public float cameraSpeed;
    
    public GameObject mainCamera;
    Vector3 ThirdP_camera;
    public Transform cameraPivot;
    bool fps=false; 

    private void Start()
    {
        ThirdP_camera= mainCamera.transform.localPosition; 
    }

    private void Update()
    {
      
       FollowPlayer();
        RotateCamera();

        if (Input.GetMouseButtonDown(1))  // 0= izquierdo , 1= derecho, 2= scroll
        {
           // SwitchCamera();
        }
    }
    public void FollowPlayer()
    {
        Vector3 targetPos = Vector3.SmoothDamp(transform.position, playerTransform.position, ref followVelocity, followSpeed);

        transform.position = targetPos; 

    }

    public void RotateCamera()
    {
        lookAngleY = lookAngleY + (inputManger.horizontalCamera* cameraSpeed);

        Vector3 rotation = Vector3.zero;
        rotation.y = lookAngleY;

        Quaternion targetRotation = Quaternion.Euler(rotation);
        transform.localRotation = targetRotation; 

    }

    public void SwitchCamera()
    {
        if (fps)
        {
            mainCamera.transform.localPosition = ThirdP_camera; // cambia a third person 
            fps = false; 
        }
        else
        {
            mainCamera.transform.localPosition = cameraPivot.localPosition;  // cambia a first person 
            fps = true;
        }
    }
}

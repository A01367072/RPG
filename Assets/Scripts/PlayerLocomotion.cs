using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
     InputManger inputManger;
    Transform camaraTransform;
    Vector3 Direccion;
    Rigidbody playerRb;
    Animator animator; 

    public float speed = 5f;
    public float rotSpeed = 5f; 
    public float gravedad = 100f; 
    


    private void Awake()
    {
        inputManger = GetComponent<InputManger>();
        camaraTransform = Camera.main.transform;
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>(); 
    }
    private void FixedUpdate()
    {
        Mover();
        Rotar();
    }
  

    public void Mover()
    {
        Vector3 CameraForward = new Vector3(camaraTransform.forward.x, 0, camaraTransform.forward.z);
        Direccion = CameraForward * inputManger.verticalInput;
        Direccion = Direccion + camaraTransform.right * inputManger.horizontalInput;
        Direccion.y -= gravedad* Time.deltaTime;
        Direccion.Normalize(); // para que quede en un valo entre 0 y 1 
        //Direccion.y = 0; 
      


        Direccion = Direccion * speed; //(1,0)*100 = (100,0)

        // mover al personaje 
        playerRb.velocity = Direccion;

        if(Direccion.x==0 && Direccion.z==0)  // x= horizontal y z= mov vertical 
        {
            animator.SetBool("run", false);
        }
        else
        {
            animator.SetBool("run", true);
        }
    }

    public void Rotar()
    {
        Vector3 DireccionRotacion = Vector3.zero; // (0,0,0)
        Vector3 CameraForward = new Vector3(camaraTransform.forward.x, 0, camaraTransform.forward.z);
        DireccionRotacion = CameraForward * inputManger.verticalInput;
       DireccionRotacion=  DireccionRotacion + camaraTransform.right * inputManger.horizontalInput;
        DireccionRotacion.Normalize();

        if( DireccionRotacion== Vector3.zero)
        {
            DireccionRotacion = transform.forward; 
        }
       Quaternion rotacion = Quaternion.LookRotation(DireccionRotacion);  // calcula la reotación que debe hacer el personaje para ver al frente
        Quaternion playerRot = Quaternion.Slerp(transform.rotation, rotacion, rotSpeed * Time.deltaTime);  //  (rotInicial, rot final, tiempo de rotacion) 

        // rotar al personaje 
      
        transform.rotation = playerRot; 
    }

}

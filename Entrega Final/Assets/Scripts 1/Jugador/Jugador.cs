using Assets.Scripts.Jugador;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    private GameObject proyectil;
    public GameObject bola;
    public GameObject bala;
    public GameObject slime;
    public GameObject imanP;
    public GameObject imanN;
    public GameObject jugador;
    public Camera cam;
    private Controles1 controles;
    private Controles1.ControlesJugadorActions playerInputs;
    private CameraLook LookControl;
    private int contador = 0;
    public float Sensi = 30f;
    private float rotationX = 0;
    private float rotationY = 0;
    
 
    Vector2 mouseLook;

    private void Awake()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        controles = new Controles1();
        playerInputs = controles.ControlesJugador;
        controles.Enable();

    }
    // Start is called before the first frame update
    void Start()
    {
       
       
        proyectil = bola;
       
    }

    // Update is called once per frame
    void Update()
    {
        Look();


    }

    private void Look()
    {
        mouseLook = controles.ControlesJugador.Mirar.ReadValue<Vector2>();
        float mouseX = mouseLook.x * Sensi * Time.deltaTime;
        float mouseY = mouseLook.y * Sensi * Time.deltaTime;
        rotationX -= mouseY;
        rotationY += mouseX;
        rotationY = Mathf.Clamp(rotationY, -90, 90);
        rotationX = Mathf.Clamp(rotationX, -90, 90);
        transform.localRotation = Quaternion.Euler(rotationX,rotationY,0);
        // Consigo una variable que toma los valores del V2 del movimiento del mouse.

    }

    

    private void FixedUpdate()
    {
       
    }

    public void OnSeleccionarbola(InputValue valor)
    {
       proyectil = bola;

    }

    public void OnSeleccionarbala(InputValue valor)
    {
        proyectil = bala;
    }

    public void OnSeleccionarslime(InputValue valor)
    {
        proyectil = slime;
    }

    public void OnSeleccionarimanP(InputValue valor)
    {
        proyectil = imanP;
    }

    public void OnSeleccionarimanN(InputValue valor)
    {
        proyectil = imanN;
    }

    private void OnDisparar(InputValue valor)
    {
        proyectil = Instantiate(proyectil, cam.transform.position, proyectil.transform.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(jugador.transform.forward * 1000000, ForceMode.Impulse);
        contador ++;

    }
   

    private void Cadencia()
    {
        
    }

    public void Moverse()
    {
        
    }

    
}

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
    private bool disparado = false;
    
 
    Vector2 mouseLook;

    private void Awake()
    {
        
        
        controles = new Controles1();// inicio el inputmap
        playerInputs = controles.ControlesJugador;// instancio el inputmap
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
        // Accedo del inputmap al mapa de acciones, de ahi a las acciones y por ultimno la accion
        // cuyo input es el delta del mouse asignandole el valor a una variable
        float mouseX = mouseLook.x * Sensi * Time.deltaTime;//normalizo y doy sensibilidad
        float mouseY = mouseLook.y * Sensi * Time.deltaTime;
        rotationX -= mouseY;
        rotationY += mouseX;
        rotationY = Mathf.Clamp(rotationY, -90, 90);//limito el campo de vision
        rotationX = Mathf.Clamp(rotationX, -90, 90);
        transform.localRotation = Quaternion.Euler(rotationX,rotationY,0);
        // Consigo una variable que toma los valores del V2 del movimiento del mouse.

    }

    

    private void FixedUpdate()
    {
        Dispararse();
    }
    //cada input asigna el proyectil a disparar
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
        disparado = true;
        // El input devuleve un booleano dado que no pueden convivir las fisicas con los inputs
    }

    private void Dispararse()
    {
        if(disparado == true)
        {
            proyectil = Instantiate(proyectil, cam.transform.position, proyectil.transform.rotation);// instancio el proyectil
            proyectil.GetComponent<Rigidbody>().AddForce(jugador.transform.forward * 150, ForceMode.Impulse); //aplico la fuerza de disparo
            contador++;
            disparado = false;
        }
    }
   

    private void Cadencia()
    {
        
    }

    public void Moverse()
    {
        
    }

    
}

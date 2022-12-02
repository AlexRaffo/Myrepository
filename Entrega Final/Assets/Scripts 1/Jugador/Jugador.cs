using Assets.Scripts.Jugador;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;
using System;

public class Jugador : MonoBehaviour
{
    [SerializeField] private GameObject proyectil;
    [SerializeField] private GameObject bola;
    [SerializeField] private GameObject bala;
    [SerializeField] private GameObject slime;
    [SerializeField] private GameObject imanP;
    [SerializeField] private GameObject imanN;
    [SerializeField] private GameObject jugador;
    [SerializeField] private Camera cam;
    private Controles1 controles;
    private Controles1.ControlesJugadorActions playerInputs;   
    private int contador = 0;
    [SerializeField] private float Sensi = 30f;
    private float rotationX = 0;
    private float rotationY = 0;
    private bool disparado = false;
    [SerializeField] private GameObject gun;
    [SerializeField] private Material materialArma;
    private Vector4 color1 = new Vector4 (0, 0, 0, 1);
    private Vector4 color2 = new Vector4(255, 255, 255);
    private Vector4 color3 = new Vector4(0, 191, 45);
    private Vector4 color4 = new Vector4(255, 0, 0);
    private Vector4 color5 = new Vector4(0, 52, 191);
    


    Vector2 mouseLook;

    private void Awake()
    {
                
        controles = new Controles1();// inicio el inputmap
        playerInputs = controles.ControlesJugador;// instancio el inputmap
        
    }
    // Start is called before the first frame update
    void Start()
    {    
        proyectil = bola;
        materialArma.color = Convertor(color1);

    }

    // Update is called once per frame
    void Update()
    {
        Look();
    }

    public void ActivarControles()
    {
        controles.Enable();
    }

    public void DesactivarControles()
    {
        controles.Disable();
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

    public Color Convertor(Vector3 color)
    {
        color /= 255;
        Color colorF = new Color(color.x, color.y, color.z);
        return colorF;
    }

    private void FixedUpdate()
    {
        Dispararse();
    }
    //cada input asigna el proyectil a disparar
    public void OnSeleccionarbola(InputValue valor)
    {
       proyectil = bola;
        materialArma.color = Convertor(color1);

    }

    public void OnSeleccionarbala(InputValue valor)
    {
        proyectil = bala;
        materialArma.color = Convertor(color2);
    }

    public void OnSeleccionarslime(InputValue valor)
    {
        proyectil = slime;
        materialArma.color = Convertor(color3);
    }

    public void OnSeleccionarimanP(InputValue valor)
    {
        proyectil = imanP;
        materialArma.color = Convertor(color4);
    }

    public void OnSeleccionarimanN(InputValue valor)
    {
        proyectil = imanN;
        materialArma.color = Convertor(color5);
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
            proyectil = Instantiate(proyectil, gun.transform.position, proyectil.transform.rotation);// instancio el proyectil
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
        int speed = 20;
        Vector2 valor = controles.ControlesJugador.Moverse.ReadValue<Vector2>();
        GetComponent<Rigidbody>().AddForce(new Vector3(valor.x, 0, valor.y) * speed);
    }

    
}

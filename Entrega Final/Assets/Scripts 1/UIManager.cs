using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MenuInicio;
    [SerializeField] private GameObject MenuPausa;
    [SerializeField] private GameObject Opciones;
    [SerializeField] private GameObject Controles;
    [SerializeField] private GameObject Sonidos;
    [SerializeField] private GameObject Jugador;

    void Start()
    {
        Time.timeScale = 0f;
    }

    
    void Update()
    {
        
    }

    public void Jugar()
    {
        Cursor.lockState = CursorLockMode.Locked;// bloqueo el cursor
        MenuInicio.SetActive(false);
        Time.timeScale = 1f;
    }

    public void AbrirOpciones()
    {
        Opciones.SetActive(true);
    }

    public void SalirOpciones()
    {
        Opciones.SetActive(false);
    }

    public void AbrirControles()
    {
        Controles.SetActive(true);
    }

    public void SalirControles()
    {
        Controles.SetActive(false);
    }

    public void AbrirSonidos()
    {
        Sonidos.SetActive(true);
    }

    public void SalirSonidos()
    {
        Sonidos.SetActive(false);
    }
    public void PonerPausa()
    {
        MenuPausa.SetActive(true );
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0f;
    }

    public void SalirPausa()
    {
        MenuPausa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

    public void Cerrarjuego()
    {
        Application.Quit();
    }

    public void Guardar()
    {

    }

    public void Cargar()
    {

    }
}

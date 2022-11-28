using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Proyectil : MonoBehaviour
{
    Controles1 controles;
    private Controles1.ControlesProyectilActions inputproyectil;
    // Start is called before the first frame update
    void Start()
    {
         controles = new Controles1 ();
        inputproyectil = controles.ControlesProyectil;
        controles.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    protected virtual void Dispararse() { }
    public void OnBorrar(InputValue valor)
    {
           
      
        this.IsDestroyed();
       
    }
}

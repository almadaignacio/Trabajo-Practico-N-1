using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public Humano humano;
    public string nuevoNombre;
    public string NombreActual;

    // Start is called before the first frame update
    void Start()
    {
        //humano = GetComponent<Humano>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        humano.Nombre = nuevoNombre;
        Debug.Log("Hola " + NombreActual + " Ahora te llamas: " + humano.Nombre);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Humano"))
        {
            NombreActual = humano.Nombre;
            Saludar();
        }
    }
}

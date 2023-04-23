using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humano : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    private string nombre = "Patricio";

    public string Nombre { get => nombre; set => nombre = value; }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    private void FixedUpdate()
    {
        float MovementHorizontal = Input.GetAxis("Horizontal");
        float MovementVertical = Input.GetAxis("Vertical");
        Vector3 VectorMovement = new Vector3(MovementHorizontal, 0.0f, MovementVertical);
        rb.AddForce(VectorMovement * speed);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jugador : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Si usas Unity 6 / 2023+ usa rb.linearVelocity, si usas versiones anteriores cambia a rb.velocity
        Vector3 movement = new Vector3(moveHorizontal * speed, rb.linearVelocity.y, moveVertical * speed);

        rb.linearVelocity = movement;
    }

}
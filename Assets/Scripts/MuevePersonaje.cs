using System;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{

    // transform, gameObject
    // Velocidades
    

    [SerializeField]
    private float VelocidadY;
    [SerializeField]
    private float VelocidadX;

    // Movimiento
    private Rigidbody2D rb;

    // Referencia al animator

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Inicializer rb
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame (60FPS)
    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(movHorizontal * VelocidadX, rb.linearVelocityY);

        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0){
            rb.linearVelocity = new Vector2(rb.linearVelocityX, movVertical * VelocidadY);
        }
        else {
            rb.linearVelocity = new Vector2(movHorizontal * VelocidadX, rb.linearVelocityY);
        }

    }
}

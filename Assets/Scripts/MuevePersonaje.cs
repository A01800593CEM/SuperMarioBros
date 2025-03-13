using System;
using UnityEngine;

/**
Autor: Emilio de Leon Vives
*/

public class MuevePersonaje : MonoBehaviour
{

    [SerializeField]
    private float VelocidadY;
    [SerializeField]
    private float VelocidadX;

    [SerializeField]
    private float fuerzaSaltoInicial = 5f; // Nueva variable para la fuerza del salto inicial

    // Movimiento
    private Rigidbody2D rb;

    // Referencia al animator

    // Referencia al script EstadoPersonaje
    private EstadoPersonaje estadoPersonaje;

    private bool saltando = false; // Nueva variable para controlar el estado de salto

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Inicializer rb
        rb = GetComponent<Rigidbody2D>();
        // Inicializar estadoPersonaje
        estadoPersonaje = GetComponent<EstadoPersonaje>();
        // Suscribirse al evento OnTocaSuelo
        estadoPersonaje.OnTocaSuelo += ResetSalto;
    }

    // Método para resetear el estado de salto
    private void ResetSalto()
    {
        saltando = false;
    }

    // Update is called once per frame (60FPS)
    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(movHorizontal * VelocidadX, rb.linearVelocity.y);

        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0 && estadoPersonaje.enPiso && !saltando)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSaltoInicial);
            saltando = true; // Marcar que el personaje está saltando
        }
        else if (movVertical == 0)
        {
            saltando = false; // Resetear el estado de salto cuando se suelta la tecla de salto
        }
        else
        {
            rb.linearVelocity = new Vector2(movHorizontal * VelocidadX, rb.linearVelocity.y);
        }

    }
}

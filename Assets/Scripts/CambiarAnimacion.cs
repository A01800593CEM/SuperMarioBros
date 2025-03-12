using UnityEngine;

/**
Modifica los parámetros de la animación del personaje.
Autor: Emilio de Leon Vives

*/

public class CambiarAnimacion : MonoBehaviour
{
    private Rigidbody2D rb; // Rigidbody2D del personaje
    private SpriteRenderer sr; // SpriteRenderer del personaje
    private Animator anim; // Animator del personaje

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("velocidad", Mathf.Abs(rb.linearVelocityX));
        EstadoPersonaje estadoPersonaje = GetComponent<EstadoPersonaje>();
        anim.SetBool("enPiso", estadoPersonaje.enPiso);
        sr.flipX = rb.linearVelocityX < 0;
    }
}

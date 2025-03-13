using UnityEngine;

/**
Autor: Emilio de Leon Vives
*/

public class EstadoPersonaje : MonoBehaviour
{
    public bool enPiso { get; private set; } // Variable para saber si el personaje está en el piso o no

    // Evento para notificar cuando el personaje toca el suelo
    public event System.Action OnTocaSuelo;

    void Start()
    {
        enPiso = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        enPiso = true;
        OnTocaSuelo?.Invoke(); // Invocar el evento cuando el personaje toca el suelo
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        enPiso = false;
    }
}
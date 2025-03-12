using UnityEngine;

/**
Autor: Emilio de Leon Vives
*/

public class EstadoPersonaje : MonoBehaviour
{
    public bool enPiso {get; private set;} // Variable para saber si el personaje está en el piso o no
    
    void Start()
    {
        enPiso = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        enPiso = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        enPiso = false;
    }
}
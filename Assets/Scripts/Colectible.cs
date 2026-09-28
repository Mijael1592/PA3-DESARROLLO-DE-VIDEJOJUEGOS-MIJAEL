using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectible : MonoBehaviour
{
    private bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica que la colisión sea del Jugador y que el objeto no haya sido recogido aún
        if (other.CompareTag("Player") && !collected)
        {
            collected = true;

            GameManager manager = FindAnyObjectByType<GameManager>();
            if (manager != null)
            {
                manager.AddColectible();
            }

            Destroy(gameObject);
        }
    }
}
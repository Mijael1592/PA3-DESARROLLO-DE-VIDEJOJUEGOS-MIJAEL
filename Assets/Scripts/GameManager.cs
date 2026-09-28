using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;

    [Header("UI Elements")]
    public TMP_Text ColectiblesNumbersText;
    public TMP_Text totalColectiblesNumbersText;

    private int ColectiblesNumber = 0;
    private int totalColectiblesNumber;
    private bool hasWon = false;

    void Start()
    {
        ColectiblesNumber = 0;
        
        // Cuenta el número real de hijos al arrancar la escena
        totalColectiblesNumber = transform.childCount;

        if (totalColectiblesNumbersText != null)
        {
            totalColectiblesNumbersText.text = totalColectiblesNumber.ToString();
        }

        if (ColectiblesNumbersText != null)
        {
            ColectiblesNumbersText.text = ColectiblesNumber.ToString();
        }
    }

    public void AddColectible()
    {   
        // Solo reproduce si el audio está asignado en el Inspector
        if (audioSource != null)
        {
            audioSource.Play();
        }

        ColectiblesNumber++;

        if (ColectiblesNumbersText != null)
        {
            ColectiblesNumbersText.text = ColectiblesNumber.ToString();
        }

        // Si ya recogió todas las esferas
        if (!hasWon && totalColectiblesNumber > 0 && ColectiblesNumber >= totalColectiblesNumber)
        {
            hasWon = true;
            Debug.Log("¡Ganaste! Cargando siguiente escena...");

            string currentScene = SceneManager.GetActiveScene().name;

            // Transición por nombre exacto de la escena
            if (currentScene == "Nivel 1")
            {
                SceneManager.LoadScene("Nivel 2");
            }
            else if (currentScene == "Nivel 2")
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
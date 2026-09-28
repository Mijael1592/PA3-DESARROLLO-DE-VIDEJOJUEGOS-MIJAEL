using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("¡Ganaste!");

        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        // Si hay un nivel siguiente en los Build Profiles, avanza a él
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            // Si llegaste al último nivel, vuelve al Nivel 1 (índice 0)
            SceneManager.LoadScene(0); 
        }
    }

    public void Quit()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
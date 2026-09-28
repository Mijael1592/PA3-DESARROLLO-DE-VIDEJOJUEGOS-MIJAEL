using UnityEditor.Analytics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;

    private Transform playerTransform;


    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        playerTransform = FindAnyObjectByType<Jugador>().transform;
    }
 
    void Update()
    {
        navMeshAgent.destination = playerTransform.transform.position;
    }


     private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))

        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     
        }

    }

}

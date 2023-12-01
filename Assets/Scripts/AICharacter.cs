using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICharacter : MonoBehaviour
{
    //public GameManager gameManager;
    GameObject target;
    NavMeshAgent navMesh;
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("gamemanager").GetComponent<GameManager>().spawnPoint;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        navMesh.SetDestination(target.transform.position);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("pointedbox"))
        {
            GameObject.FindWithTag("gamemanager").GetComponent<GameManager>().characterCount--;
            this.gameObject.SetActive(false);
        }
    }
}

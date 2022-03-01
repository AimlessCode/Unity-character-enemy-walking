using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{


private NavMeshAgent agant;
public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        agant = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {
        agant.SetDestination(target.position);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPat : MonoBehaviour
{
    public Transform[] wayPoint;
    public bool loopwayPoint = true;
    private NavMeshAgent agant;
    void Start()
    {
        agant = GetComponent<NavMeshAgent>();
        StartCoroutine("Patrol");
    }
    IEnumerator Patrol()
    {
        agant.SetDestination(wayPoint[0].position);
        int wayPointNumber = 0;

        while (true)
        {
            if (Vector3.Distance(wayPoint[wayPointNumber].position, transform.position) < 2)
            {
                if (wayPointNumber == wayPoint.Length - 1)
                {
                    if (loopwayPoint)
                    {
                        wayPointNumber=0;
                        agant.SetDestination(wayPoint[0].position);
                    }
                    else
                    {
                        break;
                    }
                }
                        else
                {
                    wayPointNumber++;
                    agant.SetDestination(wayPoint[wayPointNumber].position);
                }
            }
            yield return new WaitForSeconds(0.5f);
        }
        yield return null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class enemysl : MonoBehaviour
{
    public AIPath aiPth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(aiPth.desiredVelocity.x>=0.01f)
        {
            transform.localScale=new Vector3(0.6f,0.6f,0.6f);
        }
        else if(aiPth.desiredVelocity.x<= 0.01f)
        {
         transform.localScale=new Vector3(-0.6f,0.6f,0.6f);
        }
    }
}

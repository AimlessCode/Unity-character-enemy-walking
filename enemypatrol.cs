using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypatrol : MonoBehaviour
{
    public float walkspeed;
    public bool doPatrol =true;
    private bool mustTrun;
    public Transform GroundCheckPos;
    public LayerMask groundLayer;
    public Rigidbody2D rgPlayer;
    void Start()
    {
        rgPlayer=GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(doPatrol)
        {
        Patrol();
        }   
    }
    private void FixedUpdate()
    {
        if(doPatrol)
        {
            mustTrun=! Physics2D.OverlapCircle(GroundCheckPos.position,0.1f,groundLayer);
        }   
    }
    void Patrol()
    {
        if(mustTrun)
        {
            doFlip();
        }
    rgPlayer.velocity=new Vector2(walkspeed,rgPlayer.velocity.y); 
    }
    void doFlip()
    {
        doPatrol =false;
        transform.localScale =new Vector2(transform.localScale.x*-1,transform.localScale.y);
        walkspeed*=-1;
        doPatrol=true;
    }
    
}

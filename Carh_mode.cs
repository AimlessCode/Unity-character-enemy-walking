using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carh_mode : MonoBehaviour
{
        Animator charanimator;
        public float MoveS  ;
        float direction;
        private Rigidbody2D rgPlayer;
        
    void Start()
    {
    
        charanimator = GetComponent<Animator>();
        rgPlayer =GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        direction = Input.GetAxis("Horizontal");
        transform.position= new Vector2(transform.position.x +direction *MoveS * Time.deltaTime,transform.position.y);
                
        Vector3 CharacterScale=transform.localScale;
        if(direction<0){
            CharacterScale.x=-1;
        }
        if(direction>0){
            CharacterScale.x=1;
        }
        transform.localScale=CharacterScale;






        if (direction!= 0)
        {charanimator.SetBool("walk",true);}
        
        if (direction== 0)
        {charanimator.SetBool("walk",false);}

        if ((direction!= 0)&&(Input.GetKey("left shift")))
        {charanimator.SetBool("run",true);}
            
        if (!(direction!= 0)&&(Input.GetKey("left shift")))
        {charanimator.SetBool("run",false);}
            




    }
}

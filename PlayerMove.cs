using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    int moveS = 10;
    int jumpSpt = 10;
    

    
    void Update()
  {

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime* moveS,
            0f, Input.GetAxis("Vertical") * Time.deltaTime* moveS);
        
        


        if (Input.GetKey("space"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up* jumpSpt, ForceMode.Acceleration);

        }





    }
}

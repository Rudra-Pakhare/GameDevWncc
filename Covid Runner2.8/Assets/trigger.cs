using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate ()
    {
      GetComponent<Rigidbody>().velocity = new Vector3((-1)*5, GetComponent<Rigidbody>().velocity.y, 0);
    
    }  
    
    void OnCollisionEnter ( Collision collisionInfo)
    {
       if (collisionInfo.collider.tag == "sanitise" )
       {
           Debug.Log("We hit a sanitise");
           
       }
       if (collisionInfo.collider.tag == "block" )
       {
           Debug.Log("We hit a block");
       }
    }
}

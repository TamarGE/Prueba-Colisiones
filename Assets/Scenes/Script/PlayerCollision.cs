using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
       
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall" || col.gameObject.name == "DeathPlane")
        {
            //Destroy(gameObject);
            transform.position = new Vector3 (2, 2, 2);
        }  
    }
}

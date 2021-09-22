using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject projecttile;
    public float projecttilespeed;
    void Update()
    {
        
    }

    public void tembak()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
        { }*/

            GameObject bluebullet = Instantiate(projecttile, transform) as GameObject;
            Rigidbody rb = bluebullet.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * projecttilespeed;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject projecttile;
    public float projecttilespeed;
    public GameObject target;
    public AudioSource audioDubing;
    void Update()
    {
        
    }

    public void tembak()
    {
        /* if (Input.GetKeyDown(KeyCode.Space))
         { }*/
        if (!audioDubing.isPlaying)
        {
            Vector3 pos = target.transform.position;
            Quaternion rotation = target.transform.rotation;


            GameObject bluebullet = Instantiate(projecttile, pos, Quaternion.identity) as GameObject;
            Rigidbody rb = bluebullet.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * projecttilespeed;

        }



    }
}

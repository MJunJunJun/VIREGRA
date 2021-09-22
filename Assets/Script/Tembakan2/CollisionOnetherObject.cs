using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOnetherObject : MonoBehaviour
{
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Peluru"))
        {
            Destroy(collision.gameObject);
        }
    }*/


    int poin = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("virus"))
        {
            Destroy(other.gameObject);

            poin = PlayerPrefs.GetInt("health") - 1;
            PlayerPrefs.SetInt("health", poin);

            


        }

       /* if (other.CompareTag("bayangan"))
        {
            Destroy(other.gameObject);


            poin = PlayerPrefs.GetInt("health") - 1;
            PlayerPrefs.SetInt("health", poin);


        }*/
    }


    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);


            poin = PlayerPrefs.GetInt("poin") + 1;
            PlayerPrefs.SetInt("poin", poin);
        }
    }*/



}

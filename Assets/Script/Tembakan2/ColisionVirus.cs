using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionVirus : MonoBehaviour
{
    int poin = 0;

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("virus"))
        {
            Destroy(other.gameObject);


            poin = PlayerPrefs.GetInt("poin") + 1;
            PlayerPrefs.SetInt("poin", poin);


        }
    }
}

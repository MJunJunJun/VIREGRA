using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionVirus : MonoBehaviour
{
    int poin = 0;
    public int penambahan;
    public NyawaBos nyawa;
     void Start()
    {
        nyawa = GameObject.FindObjectOfType<NyawaBos>();
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("virus"))
        {
            Destroy(other.gameObject);


            poin = PlayerPrefs.GetInt("poin") + penambahan;
            PlayerPrefs.SetInt("poin", poin);


        }
        if (other.CompareTag("Bos"))
        {
            int c = Random.Range(10, 20);
            int a = nyawa.nyawaBos;
            int b = a - c;
            nyawa.nyawaBos = b;
        }
    }
}

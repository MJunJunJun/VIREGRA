using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionlevel5 : MonoBehaviour
{
    public string nama;
    
    // public GameObject asli, setelahasli;
    public int urutanBarang;
    public managemenGame5 management;
    public GameObject salah;



    private void Start()
    {
        // management.gameObject.name == "ManagementLevel3";


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == nama)
        {
            Debug.Log("MASUK");
            if (management.urutan == urutanBarang - 1)
            {
                int a = management.urutan;
                a++;
                management.urutan = a;
                // asli.SetActive(false);
                // setelahasli.SetActive(true);
                Debug.Log("MASUK");
                management.urutanPenggunaan();
            }
            else
            {
                salah.SetActive(true);
            }

        }
    }

}

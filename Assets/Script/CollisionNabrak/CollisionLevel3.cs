using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLevel3 : MonoBehaviour
{
    public string nama;
   // public GameObject asli, setelahasli;
    public int urutanBarang;
    public managementKelengkapanLevel3 management;
    public GameObject salah;



    private void Start()
    {
        // management.gameObject.name == "ManagementLevel3";
        management = GameObject.FindObjectOfType<managementKelengkapanLevel3>();
        salah.SetActive(false);
       
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == nama)
        {
            
            if (management.urutan == urutanBarang-1)
            {
                int a = management.urutan;
                a++;
                management.urutan = a;
                // asli.SetActive(false);
                // setelahasli.SetActive(true);
                Debug.Log("MASUK");
            }
            else
            {
                salah.SetActive(true);
            }
            
        }
    }

}

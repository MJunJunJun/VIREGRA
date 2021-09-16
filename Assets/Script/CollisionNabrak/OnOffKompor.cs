using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffKompor : MonoBehaviour
{
    public GameObject OnKompor, OffKompor;
    public string nama1, nama2;
    public int urutan1,urutan2;
    public managementKelengkapanLevel3 management;
    private void OnTriggerEnter(Collider other)
    {
        if (management.urutan - 1 == urutan1)
        {
            if (other.gameObject.name == nama1)//bersentuhan dengan tombol off
            {
                OnKompor.SetActive(true);
                OffKompor.SetActive(false);
                int a = management.urutan;
                a++;
            }

        }
        if (management.urutan - 1 == urutan2)
        {

            if (other.gameObject.name == nama2)//bersentuhan dengan tombol on
            {
                OnKompor.SetActive(false);
                OffKompor.SetActive(true);
                int a = management.urutan;
                a++;
            }
        }

    }
}
//5 nunggu
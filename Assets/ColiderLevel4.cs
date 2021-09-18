using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderLevel4 : MonoBehaviour
{
    public GameObject panel;
    public string nama;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == nama)
        {
            panel.SetActive(true);
            

        }
    }
}

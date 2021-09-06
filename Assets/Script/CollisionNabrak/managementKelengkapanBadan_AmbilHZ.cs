using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementKelengkapanBadan_AmbilHZ : MonoBehaviour
{
    public string nama;
    //public int JumlahAmbilbarang;
    public UI_InteractionController managementMenang;
    private void Start()
    {
        PlayerPrefs.SetInt("level1", 0);
    }
    public GameObject handsanitizerasli, handsanitizertubuh;
    private void OnTriggerEnter(Collider other)
    {
        int b = managementMenang.JumlahPlayerPrefers;


        int a = PlayerPrefs.GetInt("level1");
        a++;
        if (other.gameObject.name == nama)
        {
            Debug.Log("HEH!");
            
            PlayerPrefs.SetInt("level1", a);
            handsanitizerasli.SetActive(false);
            handsanitizertubuh.SetActive(true);
        }

        if (a >= b)
        {
            managementMenang.win = true;
        }
        
    }



     /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="box")
        {
            Destroy(collision.gameObject);
        }
    }*/

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("TriggerObject"))
        {
            Destroy(other.gameObject);
        }
    }*/






}

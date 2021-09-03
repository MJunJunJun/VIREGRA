using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementKelengkapanBadan_AmbilHZ : MonoBehaviour
{
    public string nama;
    private void Start()
    {
        PlayerPrefs.SetInt("level1", 0);
    }
    public GameObject handsanitizerasli, handsanitizertubuh;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == nama)
        {
            Debug.Log("HEH!");
            int a = PlayerPrefs.GetInt("level1");
            a++;
            PlayerPrefs.SetInt("level1", a);
            handsanitizerasli.SetActive(false);
            handsanitizertubuh.SetActive(true);
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

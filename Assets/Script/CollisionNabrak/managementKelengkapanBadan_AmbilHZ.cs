using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementKelengkapanBadan_AmbilHZ : MonoBehaviour
{
    public string nama;
    //public int JumlahAmbilbarang;
    public UI_InteractionController managementMenang;
   // public level2 managementLevel2;



    private void Start()
    {
        //PlayerPrefs.SetInt(namaLevel, 0);
    }
    public GameObject handsanitizerasli, handsanitizertubuh;
    private void OnTriggerEnter(Collider other)
    {
        int b = managementMenang.JumlahPlayerPrefers;
        if (other.gameObject.name == nama)
        {
            int a = managementMenang.jumlahMisiSekarang;
            a++;
            Debug.Log("HEH!");

            managementMenang.jumlahMisiSekarang = a;
            handsanitizerasli.SetActive(false);
            handsanitizertubuh.SetActive(true);

            

            if (a >= b)
            {
                managementMenang.win = true;
                //managementMenang.OnEnable();
                managementMenang.panelMenang.SetActive(true);
                managementMenang.UIMODE();
                //managementMenang.ActivateUIMode();
            }
            //level2
            
        }

        


    }







}

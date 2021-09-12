using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementKelengkapanBadan_AmbilHZ : MonoBehaviour
{
    public string nama;
    //public int JumlahAmbilbarang;
    public UI_InteractionController managementMenang;
    public level2 managementLevel2;
    public string namaLevel;
    public bool level2,piringA,piringB;
    //public GameObject apleA, ApleB;
    public Vector3 lokApleA, lokApleB;
    //public GrabLevel2 grabLevel2;
    private void Awake()
    {
        if (level2)
        {
            lokApleA = handsanitizerasli.transform.position;
            lokApleB = handsanitizertubuh.transform.position;
        }
    }
    private void Start()
    {
        PlayerPrefs.SetInt(namaLevel, 0);
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

            if (level2 && piringA)
            {
                int A1 = managementLevel2.piringA;
                A1--;
                managementLevel2.piringA = A1;
                int B1 = managementLevel2.piringB;
                B1++;
                managementLevel2.piringA = B1;
                //handsanitizertubuh.transform.position = lokApleB;
                managementLevel2.getValue();


            }
            if (level2 && piringB)
            {
                int B1 = managementLevel2.piringB;
                B1--;
                managementLevel2.piringA = B1;

                int A1 = managementLevel2.piringA;
                A1++;
                managementLevel2.piringA = A1;
                managementLevel2.getValue();
                //handsanitizerasli.transform.position = lokApleA;
            }

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

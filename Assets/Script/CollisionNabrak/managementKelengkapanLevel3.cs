using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementKelengkapanLevel3 : MonoBehaviour
{
    public Animator animasiscene3;
    public GameObject wajan, jagungWajan,tutupWajan, Popcorn, PopcornMeledak,oFFKompor,api,minyakDiwajan;
    public GameObject wajanGerak,tutupWajanGerak, jagungGerak,ONKompor;
    public int urutan;
    public UI_InteractionController controlMenang;
    
    // Start is called before the first frame update
    void Start()
    {
        urutan = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void urutanPenggunaan()
    {
        if (urutan == 1)
        {
            wajan.SetActive(true);
            wajanGerak.SetActive(false);
        }
        if (urutan == 2)
        {
            oFFKompor.SetActive(false);
            ONKompor.SetActive(true);
        }
        if (urutan == 3)
        {
            minyakDiwajan.SetActive(true);
        }
        if (urutan == 4)
        {
            jagungGerak.SetActive(false);
            jagungWajan.SetActive(true);
        }
        if (urutan == 5)
        {
            //nunggu play suara dari suara menambahkan variable
        }
        if (urutan == 6)
        {
            //matikan kompor
            oFFKompor.SetActive(true);
            ONKompor.SetActive(false);

        }
        if(urutan == 7)
        {
            //win
            controlMenang.win = true;
            controlMenang.panelMenang.SetActive(true);
            controlMenang.UIMODE();

        }
    }
}

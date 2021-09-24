using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementKelengkapanLevel3 : MonoBehaviour
{
    public Animator animasiscene3;
    public GameObject wajan, jagungWajan,tutupWajan, Popcorn, PopcornMeledak,oFFKompor,api,minyakDiwajan;
    public GameObject wajanGerak,tutupWajanGerak, jagungGerak,ONKompor,tutupMinyak;
    public int urutan;
    public UI_InteractionController controlMenang;
    public GameObject suaraProses;
    public CollisionLevel3 minyak;
    public BoxCollider minyakBox;
    
    // Start is called before the first frame update
    void Start()
    {
        urutan = 0;
        wajan.SetActive(false);
        jagungWajan.SetActive(false);
        tutupWajan.SetActive(false);
        Popcorn.SetActive(false);
        PopcornMeledak.SetActive(false);
        oFFKompor.SetActive(true);
        ONKompor.SetActive(false);
        api.SetActive(false);
        minyakDiwajan.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        urutanPenggunaan();
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
            minyakDiwajan.SetActive(true);
            minyak.enabled = false;
            minyakBox.enabled = false;
            tutupMinyak.SetActive(false);
        }
        if (urutan == 3)
        {
            oFFKompor.SetActive(false);
            ONKompor.SetActive(true);
            api.SetActive(true);
        }
        if (urutan == 4)
        {
            jagungGerak.SetActive(false);
            jagungWajan.SetActive(true);
        }
        if (urutan == 5)
        {
            tutupWajan.SetActive(true);
            tutupWajanGerak.SetActive(false);
            suaraProses.SetActive(true);
            
        }
        if (urutan == 6)
        {
            //nunggu play suara dari suara menambahkan variable
            Popcorn.SetActive(true);
            PopcornMeledak.SetActive(true);
            jagungWajan.SetActive(false);
        }
        if (urutan == 7)
        {
            //matikan kompor
            api.SetActive(false);
            oFFKompor.SetActive(true);
            ONKompor.SetActive(false);

            controlMenang.win = true;
            controlMenang.panelMenang.SetActive(true);
            controlMenang.enabled = true;
            controlMenang.UIMODE();
            Time.timeScale = 0;

        }
        if(urutan == 8)
        {
            //win
            

        }
    }
}

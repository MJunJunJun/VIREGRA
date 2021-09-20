using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managemenGame5 : MonoBehaviour
{
    public int urutan;

    public UI_InteractionController controlMenang;
    public GameObject skop1, skop2, skop3, skop4;
    public GameObject tanahDiskop,bunga,bungaDipot;
    public GameObject tanahdiPot1, tanahdiPot2;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void urutanPenggunaan()
    {
        if (urutan == 1)
        {
            skop1.SetActive(false);
            skop2.SetActive(true);
            tanahDiskop.SetActive(true);
        }else if (urutan == 2)
        {
            skop2.SetActive(false);
            skop3.SetActive(true);
            tanahDiskop.SetActive(false);
            tanahdiPot1.SetActive(true);
        }else if (urutan == 3)
        {
            bunga.SetActive(false);

            bungaDipot.SetActive(true);
        }else if(urutan == 4)
        {
            skop3.SetActive(false);
            skop4.SetActive(true);
            tanahDiskop.SetActive(true);
        }else if(urutan==5)
        {
            tanahDiskop.SetActive(false);
            tanahdiPot2.SetActive(true);
            controlMenang.win = true;
            controlMenang.panelMenang.SetActive(true);
            controlMenang.UIMODE();
            Time.timeScale = 0;
        }
        else if (urutan == 6)
        {
            
           
        }

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagementPenghitunganJam : MonoBehaviour
{
    public int jamDepan,jamBelakang,MenitDepan,MenitBelakang;
    public TextMeshProUGUI textJamDepan,textJamBelakang,textMenitDepan,textMenitBelakang;
    //public bool kepala;
    //public ManagementPenghitunganJam ekor;
    public UI_InteractionController controlMenang;
    public GameObject suaraSalah;

    #region Jam
    public void nextJamDepan(int max)
    {
        jamDepan++;
        if (jamDepan >= max)
        {
            jamDepan = max;
            nextJamBelakang(9);
            //jamBelakang = 4;///CEK BAGIAN INI CUK
            textJamDepan.text = jamDepan.ToString();
        }
        textJamDepan.text = jamDepan.ToString();
    }





    public void prevJamDepan(int max)
    {
        jamDepan--;
        if (jamDepan < 0)
        {
            jamDepan = 0;
        }
        textJamDepan.text = jamDepan.ToString();
    }


    public void nextJamBelakang(int max)
    {
        if (jamDepan <= 2)
        {
            if (jamDepan == 2)
            {
                max = 3;
            }
            jamBelakang++;
            if (jamBelakang > max&&jamDepan<2)
            {
                jamBelakang = 0;
                nextJamDepan(2);
            }else if(jamBelakang > max && jamDepan >1)
            {
                jamBelakang = 3;
                //nextJamDepan(2);
            }
            textJamBelakang.text = jamBelakang.ToString();
        }

        

    }
    public void prevJamBelakang(int max)
    {
        jamBelakang--;
        if (jamBelakang <0)
        {
            jamBelakang = max;
            prevJamDepan(2);
        }
        textJamBelakang.text = jamBelakang.ToString();

    }
    #endregion

    #region Menit
    public void nextMenitDepan(int max)
    {
        MenitDepan++;
        if (MenitDepan >= max)
        {
            MenitDepan = max;
            nextMenitBelakang(9);
            //MenitBelakang = 0;
        }
        textMenitDepan.text = MenitDepan.ToString();
        textMenitBelakang.text = MenitBelakang.ToString();
    }
    public void prevMenitDepan(int max)
    {
        MenitDepan--;
        if (MenitDepan < 0)
        {
            MenitDepan = 0;
        }
        textMenitDepan.text = MenitDepan.ToString();
    }


    public void nextMenitBelakang(int max)
    {
        if (MenitDepan <= 5)
        {
            MenitBelakang++;

            if (MenitBelakang > max&&MenitDepan<5)
            {
                MenitBelakang = 0;
                nextMenitDepan(5);
            }
            else if(MenitBelakang > max && MenitDepan >4)
            {
                MenitBelakang = 9;
                //nextMenitDepan(5);
            }
            textMenitBelakang.text = MenitBelakang.ToString();
        }

        
    }
    public void prevMenitBelakang(int max)
    {
        MenitBelakang--;
        
        if (MenitBelakang <0)
        {
            MenitBelakang = 0;
            prevMenitDepan(6);
        }
        textMenitBelakang.text = MenitBelakang.ToString();
    }
    #endregion

    public void Cek()
    {
        if (jamDepan == 0 && jamBelakang == 7 && MenitDepan == 1 && MenitBelakang == 5)
        {
            controlMenang.win = true;
            controlMenang.panelMenang.SetActive(true);
            controlMenang.UIMODE();
            Time.timeScale = 0;
        }
        else
        {
            suaraSalah.SetActive(true);
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        jamDepan = 0;
        jamBelakang = 0;
        MenitDepan = 0;
        MenitBelakang = 0;
        textJamDepan.text = "0";
        textJamBelakang.text = "0";
        textMenitDepan.text = "0";
        textMenitBelakang.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

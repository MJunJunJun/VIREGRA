using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Dubing : MonoBehaviour
{
    public AudioSource dubing;
    public UI_InteractionController kontrol;
    public GameObject suaraDubing;
    public bool adaPetunjuk;// untuk level1
    public GameObject tombol;
    public GameObject bgSound;
    public XRRayInteractor managementTeleportKetikaDubingSelesai;
    public TeleportationArea portal;
    public bool lawanRaja;
    public GameObject pistolSpwaner;
    //public bool level1;

    private void Start()
    {
        //kontrol.kontrolTanganKanan = false;
        //kontrol.enabled = false;
        Time.timeScale = 0;
        //managementTeleportKetikaDubingSelesai.enabled = false;
        portal.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!dubing.isPlaying)
        {
            if (lawanRaja)
            {
                pistolSpwaner.SetActive(true);
            }
            //kontrol.enabled = true;
            if (adaPetunjuk)
            {
                tombol.SetActive(true);
                bgSound.SetActive(true);
                //kontrol.selesaiPetunjuk();

            }
            else
            {
                Time.timeScale = 1;
                if (!lawanRaja)
                {
                    kontrol.panelPause.SetActive(true);
                }
                
            }
            
            //
            suaraDubing.SetActive(false);
            portal.enabled = true;
        }
        else
        {
            Time.timeScale = 0;
            if (lawanRaja)
            {
                pistolSpwaner.SetActive(false);
            }
            
        }
        
    }
}

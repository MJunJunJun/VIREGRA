using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Dubing : MonoBehaviour
{
    public AudioSource dubing;
    UI_InteractionController kontrol;
    public GameObject suaraDubing;
    public bool adaPetunjuk;
    public GameObject tombol;
    public GameObject bgSound;
    public XRRayInteractor managementTeleportKetikaDubingSelesai;
    public TeleportationArea portal;

    private void Start()
    {
        //kontrol.kontrolTanganKanan = false;
        kontrol.enabled = false;
        Time.timeScale = 0;
        managementTeleportKetikaDubingSelesai.enabled = false;
        portal.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!dubing.isPlaying)
        {
            //kontrol.enabled = true;
            if (adaPetunjuk)
            {
                tombol.SetActive(true);
                bgSound.SetActive(true);

            }
            
            Time.timeScale = 1;
            suaraDubing.SetActive(false);
            portal.enabled = true;
        }
        
    }
}

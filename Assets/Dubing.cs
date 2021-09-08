using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dubing : MonoBehaviour
{
    public AudioSource dubing;
    UI_InteractionController kontrol;
    public GameObject suaraDubing;
    public bool adaPetunjuk;
    public GameObject tombol;

    private void Start()
    {
        //kontrol.kontrolTanganKanan = false;
        kontrol.enabled = false;

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
            }
            suaraDubing.SetActive(false);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bell : MonoBehaviour
{
    public UI_InteractionController controlMenang;
    public GameObject salah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void klikBell(bool benar)
    {
        if (benar)
        {
            controlMenang.win = true;
            controlMenang.panelMenang.SetActive(true);
            controlMenang.UIMODE();
            Time.timeScale = 0;
        }
        else
        {
            salah.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyawaBos : MonoBehaviour
{
    public float nyawaBos;
    public KontrolPistol controlMenang;
    public GameObject menang;
    public GameObject bosKorona;
    // Start is called before the first frame update
    void Start()
    {
        nyawaBos = 250;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cekNyawa()
    {
        if (nyawaBos <= 0)
        {
            controlMenang.win = true;
            controlMenang.panelMenang.SetActive(true);
            //controlMenang.UIMODE();
            controlMenang.winnn();
            menang.SetActive(true);
            Time.timeScale = 1;
            controlMenang.UICanvasGameobject.SetActive(true);
            bosKorona.SetActive(false);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyawaBos : MonoBehaviour
{
    public float nyawaBos;
    public KontrolPistol controlMenang;
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
            controlMenang.UIMODE();
            Time.timeScale = 0;


            //kontrolMenang.
            //controlMenang.win = true;
            //controlMenang.panelMenang.SetActive(true);
            /*controlMenang.UICanvasGameobject.SetActive(true);
            controlMenang.panelkalah.SetActive(true);
            controlMenang.UIMODE();
            //controlMenang.Kalah();
            Time.timeScale = 0;
            Destroy(this.gameObject);
            */

            /*PlayerPrefs.SetFloat("gameover", 1);
            controlMenang.waktuhabis = true;
            //kontrolUI.OnEnable();
            controlMenang.panelkalah.SetActive(true);
            controlMenang.UIMODE();
            this.gameObject.SetActive(false);*/
        }
    }
}

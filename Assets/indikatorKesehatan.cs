using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class indikatorKesehatan : MonoBehaviour
{
    public Image image;
    public HealthPlayer healt;
    float awal = 100;
    float perubahan;
    public GameObject pistol;
    public GameObject kalah;

    public KontrolPistol controlMenang;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        perubahan = healt.nyawa;

        float persen = healt.nyawa / awal;
        image.fillAmount = persen;

        if (persen <= 0)
        {
            /*PlayerPrefs.SetFloat("gameover", 1);
            kontrolUI.waktuhabis = true;
            //kontrolUI.OnEnable();
            kontrolUI.panelkalah.SetActive(true);
            */
            PlayerPrefs.SetFloat("gameover", 1);
            controlMenang.panelkalah.SetActive(true);
            controlMenang.UICanvasGameobject.SetActive(true);
            //controlMenang.UIMODE();
            controlMenang.Kalah();
            controlMenang.waktuhabis = true;
            this.gameObject.SetActive(false);
            pistol.SetActive(false);
            kalah.SetActive(true);
        }
        

    }
}

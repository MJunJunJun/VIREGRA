using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class TImer : MonoBehaviour
{

    public UI_InteractionController kontrolUI;

    public float detik = 0f;
    public float detikAwal;
    public float menit;
   // public GameObject halo;

    [SerializeField] Text textHitungMundur;

    // Start is called before the first frame update
    void Start()
    {
        detik = detikAwal;
        PlayerPrefs.SetFloat("gameover", 0);
    }

    // Update is called once per frame
    void Update()
    {
       // halo.SetActive(true);
       // Debug.Log("HALO");
        detik -= 1 * Time.deltaTime;
        textHitungMundur.text = menit.ToString("0")+":" + detik.ToString("0");

        if (detik <= 0)
        {
            if (menit > 0)
            {
                menit--;
                detik = 59;
            }
            else
            {
                menit = 0;
                detik = 0;
                PlayerPrefs.SetFloat("gameover", 1);
                kontrolUI.waktuhabis=true;
                //kontrolUI.OnEnable();
                kontrolUI.panelkalah.SetActive(true);

            }
            
        }
    }
}

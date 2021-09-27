using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2 : MonoBehaviour
{
    public int piringA, piringB;
    public UI_InteractionController controlMenang;
    public GameObject sebelum, sesudah;
    // Start is called before the first frame update
    void Start()
    {
                
    }

    public void getValue()
    {
        if (piringA == piringB && piringA != 0&&piringA>=3)
        {
            controlMenang.win = true;
            controlMenang.panelMenang.SetActive(true);
            controlMenang.UIMODE();
            sebelum.SetActive(false);
            sesudah.SetActive(true);
        }


    }


    // Update is called once per frame
    void Update()
    {
        //getValue(); 
    }
}

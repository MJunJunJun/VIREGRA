using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2 : MonoBehaviour
{
    public int piringA, piringB;
    public UI_InteractionController controlMenang;
    // Start is called before the first frame update
    void Start()
    {
                
    }

    void getValue()
    {
        if (piringA == piringB)
        {
            controlMenang.win=true;
            controlMenang.panelMenang.SetActive(true);
            controlMenang.UIMODE();
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

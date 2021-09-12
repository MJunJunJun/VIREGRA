using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cekNil1i2 : MonoBehaviour
{
    public level2 level;
    public Text text1,text2;
    // Update is called once per frame
    void Update()
    {
        text1.text=level.piringA.ToString();
        text2.text=level.piringB.ToString();
    }
}

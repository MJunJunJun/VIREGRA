using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonScriptTest : MonoBehaviour
{
    public TextMeshProUGUI text;
    public void onButtonPressed()
    {
        text.text = "halo";
    }
}

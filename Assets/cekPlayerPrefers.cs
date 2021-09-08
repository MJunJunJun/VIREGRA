using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cekPlayerPrefers : MonoBehaviour
{
    public Text text;
    public UI_InteractionController ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ui.jumlahMisiSekarang+ " " + ui.JumlahPlayerPrefers;

    }
}

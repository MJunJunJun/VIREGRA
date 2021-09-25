using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lawanBos : MonoBehaviour
{
   
    public Text  Poin, TotalPoin;
    public float nilaiPoinPerLevel, perhitunganAkhirNilaiPoin;// nilai poin adalah bonus mengambil / menyelesaikan misi, perhitungan akhir adalah perhgitungan untuk text poin

    // Start is called before the first frame update
    void Start()
    {
        nilaiPoinPerLevel = PlayerPrefs.GetInt("poin");
        float a = PlayerPrefs.GetInt("TotalPoin");
        float b = nilaiPoinPerLevel + a;
        TotalPoin.text = b.ToString("0");
        Poin.text = nilaiPoinPerLevel.ToString("0");
        PlayerPrefs.SetFloat("TotalPoin", b);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

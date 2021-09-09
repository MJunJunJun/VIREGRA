using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managementMenangPoin : MonoBehaviour
{
    public TImer waktu;
    public Text Timer, Poin, TotalPoin;
    public float nilaiPoinPerLevel,perhitunganAkhirNilaiPoin;// nilai poin adalah bonus mengambil / menyelesaikan misi, perhitungan akhir adalah perhgitungan untuk text poin
    float convertMenitDetik,totalDetik;
    // Start is called before the first frame update
    void Start()
    {
        Timer.text = waktu.menit.ToString("0") + ":" + waktu.detik.ToString("0");
        convertMenitDetik = waktu.menit * 60;
        totalDetik = convertMenitDetik + waktu.detik;
        perhitunganAkhirNilaiPoin = (totalDetik*2) + nilaiPoinPerLevel;
        Poin.text = perhitunganAkhirNilaiPoin.ToString("0");
        float a = PlayerPrefs.GetFloat("TotalPoin");
        a = a + perhitunganAkhirNilaiPoin;
        TotalPoin.text = a.ToString("0");
        PlayerPrefs.SetFloat("TotalPoin", a);//untuk total poin yang didapat

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

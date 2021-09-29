using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreUpdate : MonoBehaviour
{
    public float score1, score2, score3, score4, score5;
    public TextMeshProUGUI textScore1, textScore2, textScore3, textScore4, textScore5;
    float scoreLocal,perubahan1, perubahan2, perubahan3, perubahan4;
    // Start is called before the first frame update
    private void Awake()
    {
        scoreLocal = PlayerPrefs.GetFloat("TotalPoin");
        perubahan1 = PlayerPrefs.GetFloat("TotalPoin") + score1;
        perubahan2 = PlayerPrefs.GetFloat("TotalPoin") + score2;
        perubahan3 = PlayerPrefs.GetFloat("TotalPoin") + score3;
        perubahan4 = PlayerPrefs.GetFloat("TotalPoin") + score4;
    }
    void Start()
    {
        
        Debug.Log(PlayerPrefs.GetFloat("TotalPoin"));
        if (PlayerPrefs.GetFloat("TotalPoin") == 0)
        {
            textScore1.text = score1.ToString("0");
            textScore2.text = score2.ToString("0");
            textScore3.text = score3.ToString("0");
            textScore4.text = score4.ToString("0");
            textScore5.text = score5.ToString("0");
        }
        else
        {
            

            textScore1.text = perubahan1.ToString("0");
            textScore2.text = perubahan2.ToString("0");
            textScore3.text = perubahan3.ToString("0");
            textScore4.text = perubahan4.ToString("0");
            textScore5.text = PlayerPrefs.GetFloat("TotalPoin").ToString("0");
        }
        Debug.Log(perubahan1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

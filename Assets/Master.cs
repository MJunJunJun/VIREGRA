using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    //Player Preferens poin dan health
    //top score player preferencenya adalah TopScore
    public int poin = 0;
    public int health = 5;
    public Text textPoin, textHealth, textScoreGameover;//,textHightScoregameover;
    public GameObject kanvasmain, gameover;

    private void Start()
    {
        //sebelum build aktifkan player preference
        //PlayerPrefs.SetInt("TopScore", 0);
        PlayerPrefs.SetInt("poin", 0);
        
        PlayerPrefs.SetInt("health", 5);
        kanvasmain.SetActive(true);
        gameover.SetActive(false);
    }


    private void Update()
    {
        textPoin.text = PlayerPrefs.GetInt("poin").ToString();
        textHealth.text =PlayerPrefs.GetInt("health").ToString();

        textScoreGameover.text = PlayerPrefs.GetInt("poin").ToString();
        //textHightScoregameover.text = PlayerPrefs.GetInt("TopScrore").ToString();
        if (PlayerPrefs.GetInt("health") <= 0)
        {
            gameover.SetActive(true);
            kanvasmain.SetActive(false);
            /*if(PlayerPrefs.GetInt("poin") >= PlayerPrefs.GetInt("TopScore"))
            {
                
                PlayerPrefs.SetInt("TopScore", poin);
            }*/

        }

    }


}

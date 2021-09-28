using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class openSceneTimer : MonoBehaviour
{
    public Image img;

    public float detik = 0;
    public int sceneLoad;

    int levelSekarang;
    public int levelUnlock,levelIni;
    public bool menang, kalah;
    public float detikMaks;
    // Start is called before the first frame update
    void Start()
    {
        detik = 0;
        levelSekarang = PlayerPrefs.GetInt("levelgame");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (detik <= detikMaks)
        {
            img.fillAmount = detik / detikMaks;
            detik += 1 * Time.deltaTime;
        }
        else
        {
            if (menang)
            {
                if (levelUnlock > levelSekarang)
                {
                    PlayerPrefs.SetInt("levelgame", levelUnlock);
                }
                SceneManager.LoadScene(levelUnlock);
            }
            if (kalah)
            {
                SceneManager.LoadScene(levelIni);
            }

            
        }


    }
}

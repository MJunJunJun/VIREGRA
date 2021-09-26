using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagementLevel : MonoBehaviour
{
    int levelSekarang;
    public int levelUnlock;
    
    private void Start()
    {
        levelSekarang = PlayerPrefs.GetInt("levelgame");

    }
    public void levelSelanjutnya()
    {
        if (levelUnlock > levelSekarang)
        {
            PlayerPrefs.SetInt("levelgame", levelUnlock);
        }
        SceneManager.LoadScene(levelUnlock);
    }
    public void restart(bool restart)
    {
        if (restart)
        {
            PlayerPrefs.SetInt("levelgame", 0);
        }
    }
}

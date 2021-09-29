using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementPilihLevel : MonoBehaviour
{
    public GameObject level2, level3, level4, level5, level6, level7;
    public GameObject bayanganLevel2, bayanganLevel3, bayanganLevel4, bayanganLevel5, bayanganLevel6, bayanganLevel7;
    public int CekPlayerPreferes;
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        CekPlayerPreferes = PlayerPrefs.GetInt("levelgame");
        if (CekPlayerPreferes == 3)
        {
            level2.SetActive(true);
            bayanganLevel2.SetActive(false);
            level3.SetActive(false);
            bayanganLevel3.SetActive(true);
            level4.SetActive(false);
            bayanganLevel4.SetActive(true);
            level5.SetActive(false);
            bayanganLevel5.SetActive(true);
            level6.SetActive(false);
            bayanganLevel6.SetActive(true);
            level7.SetActive(false);
            bayanganLevel7.SetActive(true);
        }
        else if (CekPlayerPreferes == 4)
        {
            level2.SetActive(true);
            bayanganLevel2.SetActive(false);
            level3.SetActive(true);
            bayanganLevel3.SetActive(false);
            level4.SetActive(false);
            bayanganLevel4.SetActive(true);
            level5.SetActive(false);
            bayanganLevel5.SetActive(true);
            level6.SetActive(false);
            bayanganLevel6.SetActive(true);
            level7.SetActive(false);
            bayanganLevel7.SetActive(true);
        }
        else if (CekPlayerPreferes == 5)
        {
            level2.SetActive(true);
            bayanganLevel2.SetActive(false);
            level3.SetActive(true);
            bayanganLevel3.SetActive(false);
            level4.SetActive(true);
            bayanganLevel4.SetActive(false);
            level5.SetActive(false);
            bayanganLevel5.SetActive(true);
            level6.SetActive(false);
            bayanganLevel6.SetActive(true);
            level7.SetActive(false);
            bayanganLevel7.SetActive(true);
        }
        else if (CekPlayerPreferes == 6)
        {
            level2.SetActive(true);
            bayanganLevel2.SetActive(false);
            level3.SetActive(true);
            bayanganLevel3.SetActive(false);
            level4.SetActive(true);
            bayanganLevel4.SetActive(false);
            level5.SetActive(true);
            bayanganLevel5.SetActive(false);
            level6.SetActive(false);
            bayanganLevel6.SetActive(true);
            level7.SetActive(false);
            bayanganLevel7.SetActive(true);
        }
        else if (CekPlayerPreferes == 7)
        {
            level2.SetActive(true);
            bayanganLevel2.SetActive(false);
            level3.SetActive(true);
            bayanganLevel3.SetActive(false);
            level4.SetActive(true);
            bayanganLevel4.SetActive(false);
            level5.SetActive(true);
            bayanganLevel5.SetActive(false);
            level6.SetActive(true);
            bayanganLevel6.SetActive(false);
            level7.SetActive(false);
            bayanganLevel7.SetActive(true);
        }
        else if (CekPlayerPreferes == 8)
        {
            level2.SetActive(true);
            bayanganLevel2.SetActive(false);
            level3.SetActive(true);
            bayanganLevel3.SetActive(false);
            level4.SetActive(true);
            bayanganLevel4.SetActive(false);
            level5.SetActive(true);
            bayanganLevel5.SetActive(false);
            level6.SetActive(true);
            bayanganLevel6.SetActive(false);
            level7.SetActive(true);
            bayanganLevel7.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

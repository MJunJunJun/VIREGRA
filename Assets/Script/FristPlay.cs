using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FristPlay : MonoBehaviour
{
    public GameObject pilihlevel ,mainmenu, petunjuk, about, exit;
    // Start is called before the first frame update
    void Start()
    {
        pilihlevel.SetActive(false);
        mainmenu.SetActive(false);
        petunjuk.SetActive(false);
        about.SetActive(false);
        exit.SetActive(false);
        mainmenu.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

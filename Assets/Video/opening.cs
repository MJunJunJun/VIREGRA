using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opening : MonoBehaviour
{
    public float waktu = 10f;
    public GameObject nex;
    public int nomorScene = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waktu -= Time.deltaTime;
        if (waktu <= 0)
        {
            SceneManager.LoadScene(nomorScene);
        }
    }


  
}

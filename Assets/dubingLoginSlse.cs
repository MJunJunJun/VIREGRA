using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dubingLoginSlse : MonoBehaviour
{
    public AudioSource audio;
    public GameObject canvas;
    public GameObject animasi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!audio.isPlaying)
        {
            canvas.SetActive(true);
            animasi.SetActive(false);

        }
        else
        {
            canvas.SetActive(false);
        }
    }
}

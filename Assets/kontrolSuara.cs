using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrolSuara : MonoBehaviour
{
    public AudioSource audioMenangKalah;
    public GameObject bgSound;

    // Start is called before the first frame update
    void Start()
    {
        if(audioMenangKalah.isPlaying)
        {
            bgSound.SetActive(false);
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prosesMemasakAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public managementKelengkapanLevel3 management;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            if (management.urutan <= 5)
            {
                int a = management.urutan;
                a++;
                management.urutan = a;
            }
            
        }
    }
}

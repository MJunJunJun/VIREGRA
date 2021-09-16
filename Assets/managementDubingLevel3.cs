using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managementDubingLevel3 : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioTutorial;
    public int urutan;
    // Start is called before the first frame update
    void Start()
    {
        //Suara();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Suara()
    {
        audioSource.PlayOneShot(audioTutorial[urutan]);
    }

}

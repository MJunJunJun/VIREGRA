using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSelesai : MonoBehaviour
{
    public AudioSource audioo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioo.isPlaying)
        {
            this.gameObject.SetActive(false);
        }
    }
}

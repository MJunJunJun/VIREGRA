using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dubingBos : MonoBehaviour
{
    public ActionBasedControllerManager kontrolKiri;
    public AudioSource dubing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!dubing.isPlaying)
        {
            kontrolKiri.enabled = true;
        }
        else
        {
            kontrolKiri.enabled = false;
        }
    }
}

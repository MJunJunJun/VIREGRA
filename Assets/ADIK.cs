using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADIK : MonoBehaviour
{
    public GameObject sebelum, sesudah;
    // Start is called before the first frame update
    void Start()
    {
        sebelum.SetActive(false);
        sesudah.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

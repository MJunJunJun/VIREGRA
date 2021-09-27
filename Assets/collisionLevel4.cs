using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionLevel4 : MonoBehaviour
{
    public string nama;
    public GameObject PANELJAM,bapakSebelum,bapakSesudah;
    // Start is called before the first frame update
    void Start()
    {
        PANELJAM.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == nama)
        {
            PANELJAM.SetActive(true);
            bapakSebelum.SetActive(false);
            bapakSesudah.SetActive(true);
        }
    }
}

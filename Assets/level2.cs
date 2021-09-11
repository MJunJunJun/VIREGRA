using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2 : MonoBehaviour
{
    public GameObject apleA, apleB;
    Vector3 lokApleA, lokApleB;
    Vector3 rotApleA, rotApleB;
    public bool aktifA, aktifB;
    // Start is called before the first frame update
    void Start()
    {
        getValue();        
    }

    void getValue()
    {
        if (aktifA)
        {
            lokApleA = apleA.transform.position;
            rotApleA = apleA.transform.localEulerAngles;
        }
        if (aktifB)
        {
            lokApleB = apleB.transform.position;
            rotApleB = apleB.transform.localEulerAngles;
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

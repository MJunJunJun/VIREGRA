using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabLevel2 : MonoBehaviour
{
    public GameObject A1, A2, A3, A4, A5, A6, B1, B2, B3, B4, B5, B6;
    public Vector3 lokA1, lokA2, lokA3, lokA4, lokA5, lokA6, lokB1, lokB2, lokB3, lokB4, lokB5, lokB6;
    private void Awake()
    {
        lokA1 = A1.transform.position;
        lokA2 = A2.transform.position;
        lokA3 = A3.transform.position;
        lokA4 = A4.transform.position;
        lokA5 = A5.transform.position;
        lokA6 = A6.transform.position;
        lokB1 = B1.transform.position;
        lokB2 = B2.transform.position;
        lokB3 = B3.transform.position;
        lokB4 = B4.transform.position;
        lokB5 = B5.transform.position;
        lokB6 = B6.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

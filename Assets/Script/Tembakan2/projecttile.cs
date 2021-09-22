using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projecttile : MonoBehaviour
{
    public GameObject explosionVFX;
    public float lama = 3f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Destroy(gameObject);
        Instantiate(explosionVFX,transform.position,transform.rotation);

    }

    private void Update()
    {
        lama -= Time.deltaTime;
        if (lama <= 0)
        {
            Destroy(gameObject);
        }
    }
}

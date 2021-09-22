using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float health = 15;

    private void Update()
    {
        //Debug.Log(health);
        if(health<=0)
        {
            Destroy(gameObject);
        }
    }
}

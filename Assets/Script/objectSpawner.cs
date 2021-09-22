using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawner : MonoBehaviour
{


    public GameObject enemy;
    float randX;
    Vector2 whereToSpwan;
    public float spwanRate = 2f;
    float nextSpwan = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >nextSpwan)
        {
            nextSpwan = Time.deltaTime + spwanRate;
            randX = Random.Range(-585f, 585f);
            whereToSpwan = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpwan, Quaternion.identity);
        }
    }
}

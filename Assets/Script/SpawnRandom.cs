using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRandom : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    Vector2 whereToSpwan;
   
    


    public float waktuspawn = 3;
    public Text waktu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waktu.text = "waktu" + waktuspawn.ToString("F0");
        waktuspawn -= Time.deltaTime;

        if(waktuspawn<0)
        {
            randX = Random.Range(-2256f,-565f/*, 565f*/);
            whereToSpwan = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpwan, Quaternion.identity);
            waktuspawn = 3;
        }

    }


    public void Spawn()
    {
    
    
    }

}

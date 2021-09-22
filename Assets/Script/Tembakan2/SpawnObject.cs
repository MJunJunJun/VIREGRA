using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    public GameObject food;
    public float waittospawn=5f;

    // Start is called before the first frame update
    void Start()
    {
        spawnfoof();
    }

    // Update is called once per frame
    void Update()
    {
        //ganti ke timer
        if (PlayerPrefs.GetInt("health") >= 1)
        {
            if (waittospawn <= 0)
            {
                waittospawn = 5f;
                spawnfoof();
            }

            waittospawn -= Time.deltaTime;
        }
        
    }


    public void spawnfoof()
    {
        Vector3 pos = center + new Vector3 (Random.Range(-size.x/2,size.x/2), Random.Range(-size.z / 2, size.z / 2), Random.Range(-size.y / 2, size.y / 2));
        
        
        Instantiate(food, pos, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube( center,size);
    }
}

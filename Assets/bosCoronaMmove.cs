using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosCoronaMmove : MonoBehaviour
{
    //playerpreference speed
    public string nama;
    public GameObject player;
    public float speed = 1.5f;
    public float timetoAddSpeed = 5;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("health", 100);
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

        //transform.LookAt(player.transform);
        if (PlayerPrefs.GetInt("health") >= 1)
        {
            Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1f * Time.deltaTime);

            transform.position += transform.forward * speed * Time.deltaTime;
        }

    }


}

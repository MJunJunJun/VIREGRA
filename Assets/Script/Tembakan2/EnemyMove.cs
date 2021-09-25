 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //playerpreference speed
    public string nama;
    public GameObject player;
    public float speed =1.5f;
    public float timetoAddSpeed = 5;
    public HealthPlayer nyawaPlayer;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("health", 100);
        player = GameObject.FindGameObjectWithTag("Player");
        nyawaPlayer = GameObject.FindObjectOfType<HealthPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.LookAt(player.transform);
        if (PlayerPrefs.GetInt("health")>=1)
        {
            Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1f * Time.deltaTime);

            transform.position += transform.forward * speed * Time.deltaTime;
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == nama)
        {
            Debug.Log("Halo");
            int a=nyawaPlayer.nyawa ;
            int b = a - 20;
            nyawaPlayer.nyawa = b;
            GameObject.Destroy(this.gameObject);
        }
    }

}

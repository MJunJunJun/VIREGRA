using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoronaSpawner : MonoBehaviour
{
    public float detik;

    public GameObject KoronaKroco;
    public GameObject targetSpawner;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        detik=Random.Range(5,9);
    }

    // Update is called once per frame
    void Update()
    {
        detik -= 1 * Time.deltaTime;
        //textHitungMundur.text = menit.ToString("0") + ":" + detik.ToString("0");

        if (detik <= 0)
        {
            animator.SetBool("spawn", true);


        }
    }


    public void SpawnKoronaKroco()
    {
        Vector3 pos = targetSpawner.transform.position;
        Quaternion rotation = targetSpawner.transform.rotation;


        GameObject bluebullet = Instantiate(KoronaKroco, pos, Quaternion.identity);
        Rigidbody rb = bluebullet.GetComponent<Rigidbody>();
        detik = Random.Range(5, 9);
        animator.SetBool("spawn", true);
    }

}

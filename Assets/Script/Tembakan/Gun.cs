using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public float firerate = 15f;

    public Camera fpsCam;


    public float Next;

    // Update is called once per frame
    void Update()
    {
       /* if(Input.GetKeyDown("1"))
        {
            shoot();
        }*/
        
    }

    public void shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target!=null)
            {
                target.TakeDamage(damage);
            }
        }

    }
}

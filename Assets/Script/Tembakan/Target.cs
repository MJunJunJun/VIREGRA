using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public GameObject bullet;

    void OnCollisionStay(Collision collision)
    {
        //Check to see if the Collider's name is "Chest"
        if (collision.collider.name == "BulletBlue")
        {
            //Output the message
            Debug.Log("Chest is here!");
        }
    }


    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <=0 )
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}

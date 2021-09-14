using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLevel2 : MonoBehaviour
{
    public string nama1,nama2;
    public UI_InteractionController managementMenang;
    public level2 managementLevel2;

    private void Awake()
    {

        
    }
    private void Start()
    {
        
    }
    public GameObject asli, setelahasli;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == nama1)//piring A
        {
            managementLevel2.piringA++;
            managementLevel2.getValue();

        }
        if (other.gameObject.name == nama2)//piring A
        {
            managementLevel2.piringB++;
            managementLevel2.getValue();

        }


    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == nama1)//piring A
        {
            managementLevel2.piringA--;
            managementLevel2.getValue();

        }
        if (other.gameObject.name == nama2)//piring A
        {
            managementLevel2.piringB--;
            managementLevel2.getValue();

        }
    }



}

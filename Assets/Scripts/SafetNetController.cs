using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetNetController : MonoBehaviour
{
    public GameObject playerReference;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Object"){
            Vector3 localScale = playerReference.transform.localScale;
            playerReference.transform.localScale = localScale * 1.03F;
        }
        
    }
}

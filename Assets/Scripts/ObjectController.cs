using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){
            this.GetComponent<Rigidbody>().velocity = Vector3.down;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && this.transform.position.y < 0){
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}

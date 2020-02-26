using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadController : MonoBehaviour
{
    public bool isDebug;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){
            if (isDebug) {
                this.GetComponent<Renderer>().enabled = false;
            }
            //Debug.Log(this.name + " - hole enter");
            this.GetComponent<MeshCollider>().enabled = false;
        }
        

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"){
            if (isDebug) {
                this.GetComponent<Renderer>().enabled = true;
            }
            //Debug.Log(this.name + " - hole enter");
            this.GetComponent<MeshCollider>().enabled = true;
        }
    }
}

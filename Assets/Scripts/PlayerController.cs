using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(1,10)] public float velocityMultiplier =3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = this.transform.position;
        if (Input.GetKey("down") || Input.GetKey("s")){
            this.transform.position = currentPosition + new Vector3(0,0,-1) * Time.deltaTime * velocityMultiplier;
        }
        if (Input.GetKey("up") || Input.GetKey("w")){
            this.transform.position = currentPosition + new Vector3(0,0,1) * Time.deltaTime * velocityMultiplier;
        }

        if (Input.GetKey("right") || Input.GetKey("d")){
            this.transform.position = currentPosition + new Vector3(1,0,0) * Time.deltaTime * velocityMultiplier;
        }
        if (Input.GetKey("left") || Input.GetKey("a")){
            this.transform.position = currentPosition + new Vector3(-1,0,0) * Time.deltaTime * velocityMultiplier;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionbehaviour : MonoBehaviour
{
    Material mat;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider oth)
    {
        Debug.Log("touchy touch ho gayaa..");
        if(oth.gameObject.tag == "Player")
        {
            Debug.Log("player player touchy..");
            if(this.gameObject.GetComponent<Rigidbody>().isKinematic == false)
            {
                Debug.Log("player player deathy..");
                Destroy(this.gameObject,0.5f);
            }
/* 
            if(this.gameObject.GetComponent<Rigidbody>().isKinematic == true) {
                mat = this.gameObject.GetComponentInChildren<Renderer>().material;
                mat.color = Color.red;
            }
*/
        }
        if(oth.gameObject.tag == "floor")
        {
            this.gameObject.GetComponent<Rigidbody>().isKinematic =true;
        }
    }
}

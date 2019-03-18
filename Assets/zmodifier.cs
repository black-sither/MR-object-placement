using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmodifier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(this.transform.position.z < 0)
        {
            Vector3 postmp = this.transform.position;
            postmp.z = 0;
            this.transform.position= postmp;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // this.transform.rotation = Quaternion.identity;
    }
}

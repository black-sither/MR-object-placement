using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeObject : MonoBehaviour
{
    
    // public GameObject[] placable;
    public GameObject placable;
    int itemcount=3;
    public GameObject par;
    public void enplace(Transform a)
    {
        GameObject new_chair;
        if(a==null)
        {
            new_chair = Instantiate(placable,par.transform.position,Quaternion.identity);
        }
        else
        {
            Vector3 np = new Vector3(a.position.x,a.position.y,a.position.z);
            new_chair = Instantiate(placable,np,a.rotation);
        }
        new_chair.transform.SetParent(par.transform);
        Transform t = new_chair.transform;
        t.position = new Vector3(t.position.x,par.transform.position.y + 1.2f,t.position.z);
        new_chair.GetComponent<Rigidbody>().useGravity=true;
        // new_chair.transform.localScale = new Vector3(1f,1f,1f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

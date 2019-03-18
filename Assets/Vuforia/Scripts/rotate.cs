using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class rotate : MonoBehaviour
{
    public GameObject sun;//which axes to rotate around
    public float rotationSpeed = 5.0f; //degrees per second
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.transform.position, sun.transform.up, rotationSpeed * Time.deltaTime);
    }
}

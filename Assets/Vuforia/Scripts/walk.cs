using System;
using UnityEngine;

public class walk : MonoBehaviour
{
    public GameObject source, dest;
    public float speed = 1.0f;
    Boolean walk_s = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void click()
    {
        walk_s = true;
    }

    void start_animation(GameObject source, GameObject dest)
    {
        if (Vector3.Distance(source.transform.position, dest.transform.position) > 0.5f)
        {
            float step = speed * Time.deltaTime;
            source.transform.position = Vector3.MoveTowards(source.transform.position, dest.transform.position, step);
        }
        else
        {
            walk_s = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        try
        {
            if (walk_s)
            {
                start_animation(source, dest);
            }
        }
        catch (Exception e)
        {
            print(e.Message);
        }
    }
}

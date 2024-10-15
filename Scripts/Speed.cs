using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public double speed = 0.5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            Debug.Log("Up arrow: " + speed * Input.GetAxis("Vertical"));
        } else if (Input.GetKey("down"))
        {
            Debug.Log("Down arrow: " + speed * Input.GetAxis("Vertical"));
        } else if (Input.GetKey("left"))
        {
            Debug.Log("Left arrow: " + speed * Input.GetAxis("Horizontal"));
        } else if (Input.GetKey("right"))
        {
            Debug.Log("Right arrow: " + speed * Input.GetAxis("Horizontal"));
        }
    }
}

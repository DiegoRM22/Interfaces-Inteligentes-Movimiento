using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderManager : MonoBehaviour
{
    // Start is called before the first frame update
    public CylinderToSphere automaticMovement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K)) {
            automaticMovement.enabled = !automaticMovement.enabled;
        }
        
    }
}

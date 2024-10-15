using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger detected with " + other.gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

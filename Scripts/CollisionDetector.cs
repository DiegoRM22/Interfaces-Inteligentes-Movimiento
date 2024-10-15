using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision detected with " + collision.gameObject.tag);
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger detected with " + other.gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

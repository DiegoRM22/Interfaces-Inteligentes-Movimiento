using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forwardMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private float rotationSpeed = 1.5f;
    private Transform transform;
    void Start()
    {
        transform = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Mover con Translate.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(0, horizontal * rotationSpeed, 0);
        transform.Translate(0, 0, vertical * speed * Time.deltaTime);
        Debug.DrawRay(transform.position, transform.forward, Color.green);
    }
}

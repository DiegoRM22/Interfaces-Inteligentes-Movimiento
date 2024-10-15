using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 1.5f;
    private Transform transform;
    void Start()
    {
        transform = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Mover con Translate.
        if (Input.GetKey("up")) {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        } else if (Input.GetKey("down")) {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        } else if (Input.GetKey("left")) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        } else if (Input.GetKey("right")) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}

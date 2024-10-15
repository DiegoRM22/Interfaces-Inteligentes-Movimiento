using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private Vector3 moveDirection = new Vector3(1, 0, 0);
    private Rigidbody rb;
    private Transform t;
    // Start is called before the first frame update
    void Start() {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        // Mover con Translate.
        t.Translate(moveDirection.x * speed * Time.deltaTime, moveDirection.y * speed * Time.deltaTime, moveDirection.z * speed * Time.deltaTime);
    }
}

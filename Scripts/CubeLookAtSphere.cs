using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLookAtSphere : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform sphereTransform;
    private Transform transform;
    [SerializeField] private float speed = 1.5f;

    void Start()
    {
        transform = GetComponent<Transform>();
        sphereTransform = GameObject.Find("Sphere").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Mirar hacia la esfera.
        transform.LookAt(sphereTransform);
        Vector3 direction = (sphereTransform.position - transform.position).normalized;
        transform.Translate(direction.x * speed * Time.deltaTime, 0, direction.z * speed * Time.deltaTime);
        Debug.Log(direction);
    }
}

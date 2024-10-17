using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    Rigidbody rigidbody;
    [SerializeField]
    Transform transform;

    [SerializeField]
    float speed = 10;
    [SerializeField]
    float maxSpeed = 10;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 prevPos = transform.position;
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal")* speed * Time.deltaTime, 0, Input.GetAxis("Vertical")* speed *Time.deltaTime);


        rigidbody.AddForce(movement, ForceMode.Force);


        Vector3 flatVel = new Vector3(rigidbody.velocity.x, 0f, rigidbody.velocity.y);

        // limit velocity if needed
        if (flatVel.magnitude > maxSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * maxSpeed; // calculate what max velocity would be
            rigidbody.velocity = new Vector3(limitedVel.x, rigidbody.velocity.y, limitedVel.z); // apply it
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

    public float speed;
    public float rollSpeed;
    public float pitchSpeed;

    Rigidbody rbody;
    
	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
        rbody.velocity = speed * transform.up * Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up * rollSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * -rollSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.forward * -pitchSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.forward * pitchSpeed * Time.deltaTime);
        }
        rbody.velocity = speed * (transform.rotation * Vector3.up) * Time.deltaTime;
    }
}

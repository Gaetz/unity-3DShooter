using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float speed;
    Rigidbody rbody;

	void Start () {
        rbody = GetComponent<Rigidbody>();
        rbody.velocity = speed * (transform.rotation * Vector3.up) * Time.deltaTime;
        Destroy(gameObject, 4f);
    }
	
}

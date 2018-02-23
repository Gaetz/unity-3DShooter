using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour {

    public GameObject shoot;
	
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(shoot, transform.GetChild(1).position, transform.rotation);
        }
    }
}

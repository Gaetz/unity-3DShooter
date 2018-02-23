using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour {

    public GameObject shoot;
    public float cooldown = 0.5f;

    float counter = 1f;
	
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            if(counter > cooldown)
            {
                Instantiate(shoot, transform.GetChild(1).position, transform.rotation);
                counter = 0f;
            }
        }
        counter += Time.deltaTime;
    }
}

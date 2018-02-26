using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject target;

	void Start () {
        StartCoroutine(SpawnTarget());
	}
	
	IEnumerator SpawnTarget()
    {
        while(true)
        {
            Instantiate(target);
            yield return new WaitForSeconds(0.5f);
        }
    }
}

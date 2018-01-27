using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float Damage = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Punch!");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Kick");
        }
	}
}

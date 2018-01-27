using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterMovement : MonoBehaviour {


    public float speed = 10f;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float movement = Input.GetAxis("Horizontal")* speed * Time.deltaTime;

        transform.Translate(0, 0, movement);
	}
}

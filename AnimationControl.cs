using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {
    public Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.Play("Walking");
        }

        if (Input.GetKey(KeyCode.X))
        {
            animator.Play("Kicking");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.Play("Walking");
        }
    }
}

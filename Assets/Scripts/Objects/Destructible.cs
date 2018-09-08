﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

    public float health = 10.0f;

    private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TakeDamage(float damage) {
        health -= damage;

        if (health <= 0) {
            Destroy();
        }
    }

    void Destroy() {
        animator.SetBool("Destroy", true);
    }
}

﻿using UnityEngine;
using System.Collections;

public class EnemyMover : MonoBehaviour {

    GameObject cam;
	// Use this for initialization
	void Start ()
    {
        cam = GameObject.FindGameObjectWithTag("CardboardHead");
    }
	
	// Update is called once per frame
	void Update () {

        if(Vector3.Distance(this.transform.position, cam.transform.position) < 10f)
        {
            Destroy(this.gameObject);
        }

        this.transform.position = Vector3.MoveTowards(transform.position, cam.transform.position, 5f * Time.deltaTime);



    }
}

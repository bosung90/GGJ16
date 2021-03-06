﻿using UnityEngine;
using System.Collections;

public class RitualObjectsLauncher : MonoBehaviour {

    public RitualObjectController ritualObject;
    private Vector3 _vrShooterOffset;
    AudioSource whooshSound;

    // Use this for initialization
    void Start () {
        _vrShooterOffset = new Vector3(0f, -0.4f, 1f);
        whooshSound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	    if (Cardboard.SDK.VRModeEnabled && Cardboard.SDK.Triggered && FindObjectOfType<GameController>()._deaths < 3)
        {
            GameObject vrLauncher = Cardboard.SDK.GetComponentInChildren<CardboardHead>().gameObject;
            LaunchRitualObjectFrom(vrLauncher, _vrShooterOffset);
        }
	}

    void LaunchRitualObjectFrom(GameObject origin, Vector3 shooterOffset)
    {
        Vector3 rotation = origin.transform.rotation.eulerAngles;
        rotation.x = 90f;
        Vector3 offset = origin.transform.rotation * shooterOffset;

        Instantiate(ritualObject, origin.transform.position + offset, Quaternion.Euler(rotation));

        whooshSound.Play();
    }
}

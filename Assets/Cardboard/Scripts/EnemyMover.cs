using UnityEngine;
using System.Collections;

public class EnemyMover : MonoBehaviour {

    public Vector3 velocity = new Vector3(0, 0, -4);

	// Use this for initialization
	void Start ()
    {
	    if (Cardboard.SDK.VRModeEnabled)
        {
            this.GetComponent<Rigidbody>().velocity = velocity;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z < -20f)
            Destroy(this.gameObject);
	}
}

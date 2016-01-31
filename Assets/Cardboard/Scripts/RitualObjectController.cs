using UnityEngine;
using System.Collections;

public class RitualObjectController : MonoBehaviour {

    float objSpeed = 9f;
    float rotationSpeed = 8f;
    private GameObject head;

	// Use this for initialization
	void Start () {
        head = GameObject.FindGameObjectWithTag("Head");
        this.GetComponent<Rigidbody>().velocity = head.transform.forward * objSpeed;
        this.GetComponent<Rigidbody>().angularVelocity = this.transform.forward * rotationSpeed;
        Destroy(this.gameObject, 10f);
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Head")
        {
            collision.collider.GetComponent<EnemyMover>().DieSoon();
            Destroy(gameObject);
        }
    }
}

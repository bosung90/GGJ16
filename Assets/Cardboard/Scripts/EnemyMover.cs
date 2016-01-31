using UnityEngine;

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

            GameController gameController = FindObjectOfType<GameController>();
            gameController.IncreaseDeath();
        }
        this.transform.position = Vector3.MoveTowards(transform.position, cam.transform.position, 5f * Time.deltaTime);
	}

    public void DieSoon()
    {
        GameController gameController = FindObjectOfType<GameController>();
        gameController.GotOne();
        Destroy(gameObject, 1.5f);
    }
}

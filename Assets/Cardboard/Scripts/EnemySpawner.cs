using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemyPrefab;
    private GameObject cardboardHead;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SendOneEnemy", 1f, 1.5f);
        cardboardHead = GameObject.FindGameObjectWithTag("CardboardHead");
    }

    void SendOneEnemy()
    {
        float theta = Random.Range(0, 3f * Mathf.PI / 2f);
        GameObject enemy = Instantiate(enemyPrefab, new Vector3(this.transform.position.x + Mathf.Sin(theta)*40f, 5f, this.transform.position.z + Mathf.Cos(theta) * 40f), Quaternion.identity) as GameObject;
        enemy.transform.forward = Vector3.Normalize(enemy.transform.position- cardboardHead.transform.position);
        Vector3 angle = enemy.transform.eulerAngles;
        angle.z = 180f;
        enemy.transform.eulerAngles = angle;
        //enemy.transform.eulerAngles = new Vector3(0.0f, 0.0f, 180.0f);
    }
	
	// Update is called once per frame
	void Update () {
	}
}

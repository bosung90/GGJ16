using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemyPrefab;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SendOneEnemy", 1f, 1.5f);
	}

    void SendOneEnemy()
    {
        Instantiate(enemyPrefab, new Vector3(Random.Range(-17f, 17f), 1.0f, 20.0f), Quaternion.Euler(new Vector3(0.0f, -90.0f, 0.0f)));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

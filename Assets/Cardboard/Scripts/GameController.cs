using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text VRScoreText;

    private int _score = 0;

	// Use this for initialization
	void Start () {
	
	}

    public void GotOne()
    {
        _score++;
        VRScoreText.text = "Score: " + _score;
    }
	
	// Update is called once per frame
	void Update () {
	}
}

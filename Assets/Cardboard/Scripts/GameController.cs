using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public Text VRScoreText;
    public Canvas VRGameOverCanvas;

    private int _score = 0;
    public int _deaths = 0;
    private Light light2;
    bool _flashing = false;

    // Use this for initialization
    void Start () {
        light2 = GameObject.FindGameObjectWithTag("DirectionalLight").GetComponent<Light>();
        VRGameOverCanvas.enabled = false;
	}

    public void ResetGame()
    {
        VRGameOverCanvas.enabled = false;
        _score = 0;
        _deaths = 0;
        VRScoreText.text = "Score: 0";
        SceneManager.LoadScene(0);
    }

    public void IncreaseDeath()
    {
        _deaths++;
        if (_deaths >= 3)
        {
            VRGameOverCanvas.enabled = true;
        }

        _flashing = true;
    }

    public void GotOne()
    {
        _score++;
        VRScoreText.text = "Score: " + _score;
    }
	
	// Update is called once per frame
	void Update () {
        if (_flashing)
        {
            light2.intensity += Time.deltaTime * 9;
            if (light2.intensity >= 7f)
            {
                _flashing = false;
            }
        }
        else if (light2.intensity > 4.2f)
        {
            light2.intensity -= Time.deltaTime * 9;
        }
    }
}

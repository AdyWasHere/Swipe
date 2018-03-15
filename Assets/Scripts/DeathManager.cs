using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour {

    public GameObject GameOverPanel;

	void Start () {
        GameOverPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RetryGame()
    {


        Application.LoadLevel(Application.loadedLevel);

    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }

    
}

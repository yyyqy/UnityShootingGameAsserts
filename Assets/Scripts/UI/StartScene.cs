using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

    public Button btnStart;
    public Button btnHelp;
    public Button btnExit;
	// Use this for initialization
	void Start () {
        btnStart.onClick.AddListener(PlayGame);
        btnHelp.onClick.AddListener(HelpGame);
        btnExit.onClick.AddListener(ExitGame);
    }
	
	// Update is called once per frame
    private void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    private void HelpGame()
    {
        SceneManager.LoadScene(2);
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}

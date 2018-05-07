using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseGame : MonoBehaviour {

    bool paused = true;
    public Image PauseFader;
    public Color pauseColour = new Color(0f, 0f, 0f, 0.3f);
    public Color pauseunColour = new Color(0f, 0f, 0f, 0.0f);
    public Texture IconResume;
    public Texture IconMainMenu;
    public Texture IconRestart;
    public Texture IconExit;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        EscPause();
        //OnGUI();
        //"RESUME"
    }
 
        public void EscPause()
    {
        if (paused)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                paused = false;
                Time.timeScale = 0;
                PauseFader.color = pauseColour;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                paused = true;
                Time.timeScale = 1;
                PauseFader.color = pauseunColour;
            }
        }
    }
    void OnGUI()
    {
        if (paused)
            return;
        GUILayout.BeginArea(new Rect((Screen.width - 400) / 2, (Screen.height - 600) / 2, 400, 800));
        GUILayout.BeginVertical();
        if (!paused)
        {
            if (GUILayout.Button(IconResume, GUILayout.Height(100)))
            {
                Time.timeScale = 1;
                paused = true;
                PauseFader.color = pauseunColour;
            }
            if (GUILayout.Button(IconMainMenu, GUILayout.Height(100)))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
            if (GUILayout.Button(IconRestart, GUILayout.Height(100)))
            {
                SceneManager.LoadScene(1);
                Time.timeScale = 1;
            }
            if (GUILayout.Button(IconExit, GUILayout.Height(100)))
            {
                Application.Quit();
            }
        }
        GUILayout.EndVertical();
        GUILayout.EndArea();
    }
}

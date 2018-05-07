using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour {

    public Button btnBack;

    // Use this for initialization
    void Start () {
        btnBack.onClick.AddListener(BackGame);
    }

    // Update is called once per frame
    private void BackGame()
    {
        SceneManager.LoadScene(0);
    }

}

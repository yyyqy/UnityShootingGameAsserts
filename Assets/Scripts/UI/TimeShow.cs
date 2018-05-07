using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeShow : MonoBehaviour {
    private Text Timetext;
    private float spendTime;
    private int minute;
    private int second;
    private int millisecond;
    public PlayerHealth playerHealth;

    // Use this for initialization
    void Start () {
        Timetext = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (playerHealth.currentHealth > 0)
        {
            spendTime += Time.deltaTime;
        }
        else
        {
            spendTime += 0;
        }
            minute = (int)spendTime / 60;
            second = (int)(spendTime - minute * 60);
            millisecond = (int)((spendTime - (int)spendTime) * 1000);

            Timetext.text = string.Format("Survival  Time: {0:D2}:{1:D2}:{2:D3}", minute, second, millisecond);
           

    }
}

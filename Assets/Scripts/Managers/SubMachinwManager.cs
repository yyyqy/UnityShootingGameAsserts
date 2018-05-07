using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMachinwManager : MonoBehaviour {
	public PlayerHealth playerHealth;
	public GameObject weapon;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;
	public int flag = 0;

	// Use this for initialization
	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn ()
	{
		if (playerHealth.currentHealth <= 0f) {
			return;
		} 

		if (flag == 0) {
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			Instantiate (weapon, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);

			flag = 1;
		}
	}
}

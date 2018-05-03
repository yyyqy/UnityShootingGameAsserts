using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGet_FirstAidCase : MonoBehaviour {
	GameObject player;
	WeaponShooting weapon;
	PlayerHealth health;
	WeaponManager weaponflag;

	void Awake ()
	{
		weapon = GameObject.Find ("Weapon").GetComponent<WeaponShooting> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		health = GameObject.Find ("Player").GetComponent<PlayerHealth> ();
		weaponflag = GameObject.Find ("WeaponManager 1").GetComponent<WeaponManager> ();
	}


	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == player)
		{
			health.currentHealth = 100;
			health.healthSlider.value = health.currentHealth;
			weaponflag.flag = 0;
			Destroy (gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGet_AssultRifle02 : MonoBehaviour {
	int ctype = 3;
	GameObject player;
	WeaponShooting weapon;


	void Awake ()
	{
		weapon = GameObject.Find ("Weapon").GetComponent<WeaponShooting> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}


	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == player)
		{
			weapon.type = ctype;
			Destroy (gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGet_SniperRifle : MonoBehaviour {
	int ctype = 5;
	GameObject player;
	WeaponShooting weapon;
	SniperManager weaponflag;

	void Awake ()
	{
		weapon = GameObject.Find ("Weapon").GetComponent<WeaponShooting> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		weaponflag = GameObject.Find ("WeaponManager 1").GetComponent<SniperManager> ();
	}


	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == player)
		{
			weapon.type = ctype;
			weaponflag.flag = 0;
			Destroy (gameObject);
		}
	}
}

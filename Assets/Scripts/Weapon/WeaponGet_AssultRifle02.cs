using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGet_AssultRifle02 : MonoBehaviour {
	int ctype = 3;
	GameObject player;
	WeaponShooting weapon;
	M4Manager weaponflag;

	void Awake ()
	{
		weapon = GameObject.Find ("Weapon").GetComponent<WeaponShooting> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		weaponflag = GameObject.Find ("WeaponManager 1").GetComponent<M4Manager> ();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGet_AssultRifle01 : MonoBehaviour {
	int ctype = 2;
	GameObject player;
	WeaponShooting weapon;
	WeaponManager weaponflag;

	void Awake ()
	{
		weapon = GameObject.Find ("Weapon").GetComponent<WeaponShooting> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		weaponflag = GameObject.Find ("WeaponManager 1").GetComponent<WeaponManager> ();
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

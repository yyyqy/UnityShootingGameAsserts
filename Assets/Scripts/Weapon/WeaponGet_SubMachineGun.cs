using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGet_SubMachineGun : MonoBehaviour {
	int ctype = 7;
	GameObject player;
	WeaponShooting weapon;
	SubMachinwManager weaponflag;

	void Awake ()
	{
		weapon = GameObject.Find ("Weapon").GetComponent<WeaponShooting> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		weaponflag = GameObject.Find ("WeaponManager 1").GetComponent<SubMachinwManager> ();
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

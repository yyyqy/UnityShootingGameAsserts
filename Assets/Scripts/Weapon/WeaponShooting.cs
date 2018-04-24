using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShooting : MonoBehaviour {

	public int type = 0;
	Animator anim;
	GameObject weapon, transformObj;
	string weaponName;

	// Use this for initialization
	void Awake () {
		anim = GetComponent <Animator> ();
		weapon = GameObject.Find ("Weapon");
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetInteger ("WeaponType_int", type);
		findGun();
		weapon.transform.Find ("Weapon_AssultRifle01").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_AssultRifle02").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_FlashBang").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_Grenade").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_Pistol").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_Rifle").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_RPG").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_Shotgun").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_SmokeBomb").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_SniperRifle").gameObject.SetActive (false);
		weapon.transform.Find ("Weapon_SubMachineGun").gameObject.SetActive (false);
		if (type != 0) {
			transformObj = weapon.transform.Find (weaponName).gameObject;
			transformObj.SetActive (true);
		}


	}

	void findGun(){
		switch (type) {
		case 0:
			weaponName = "";
			break;
		case 1:
			weaponName = "Weapon_Pistol";
			break;
		case 2:
			weaponName = "Weapon_AssultRifle01";
			break;
		case 3:
			weaponName = "Weapon_AssultRifle02";
			break;
		case 4:
			weaponName = "Weapon_Shotgun";
			break;
		case 5:
			weaponName = "Weapon_SniperRifle";
			break;
		case 6:
			weaponName = "Weapon_Rifle";
			break;
		case 7:
			weaponName = "Weapon_SubMachineGun";
			break;
		case 8:
			weaponName = "Weapon_RPG";
			break;
		case 9:
			weaponName = "Weapon_Grenades";
			break; 
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class WeaponDisplay : MonoBehaviour {

	public Sprite Pistol;
	public Sprite Ak47;
	public Sprite M4a1;
	public Sprite SubMachineGun;
	public Sprite Sniper;
	Image WeaponImage;
	int type;


	// Use this for initialization
	void Start () {
		WeaponImage = GameObject.Find ("WeaponDisplayImage").GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		type = GameObject.Find ("Player").transform.Find("Weapon").GetComponent<WeaponShooting> ().type;
		switch (type) {
		case 0:
			break;
		case 1:
			WeaponImage.sprite = Pistol;
			break;
		case 2:
			WeaponImage.sprite = Ak47;
			break;
		case 3:
			WeaponImage.sprite = M4a1;
			break;
		case 4:
			break;
		case 5:
			WeaponImage.sprite = Sniper;
			break;
		case 6:
			break;
		case 7:
			WeaponImage.sprite = SubMachineGun;
			break;
		case 8:
			break;
		case 9:
			break; 
		}
	}
}
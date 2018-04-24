using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 2f;

	Vector3 movement;
	Vector3 temp;
	Animator anim;
	Rigidbody playerRigidbody;
	GameObject weapon;
	WeaponShooting weaponShooting;

	int floorMask;
	float camRayLength = 100f;
	int gunType;

	void Awake()
	{
		floorMask = LayerMask.GetMask ("Floor");
		anim = GetComponent <Animator> ();
		playerRigidbody = GetComponent<Rigidbody> ();
		weaponShooting = GetComponentInChildren<WeaponShooting> ();
		temp.Set(0, 0, 0);
	}

	void FixedUpdate()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		gunType = weaponShooting.type;

		Move (h, v);
		Turning ();
		Animating (h, v);


	}

	void Move (float h, float v)
	{
		movement.Set (h, 0f, v);

		movement = movement.normalized * speed * Time.deltaTime;

		playerRigidbody.MovePosition (transform.position + movement);
	}

	void Turning()
	{
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit floorHit;

		if(Physics.Raycast (camRay, out floorHit, camRayLength, floorMask))
			{
				Vector3 playerToMouse = floorHit.point - transform.position;
				playerToMouse.y = 0f;

				Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
				playerRigidbody.MoveRotation(newRotation);
			}
	}

	void Animating(float h, float v)
	{
		if(movement != temp){
			anim.SetFloat ("Speed_f", speed);
		}
		else{
			anim.SetFloat ("Speed_f", 0);
		}
		anim.SetInteger ("WeaponType_int", gunType);
	}
}

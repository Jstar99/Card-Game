using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Battle : MonoBehaviour {

	public float bMoveSpeed;

	public Transform firePoint;
	public GameObject Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerBattleMovement ();
		PlayerShoot ();
	}

	void PlayerBattleMovement()
	{
		if (Input.GetKeyDown(KeyCode.W)) 
		{
			transform.position = new Vector2 (transform.position.x, transform.position.y + bMoveSpeed);
		}
		if (Input.GetKeyDown(KeyCode.S)) 
		{
			transform.position = new Vector2 (transform.position.x, transform.position.y - bMoveSpeed);
		}
		if (Input.GetKeyDown(KeyCode.A)) 
		{
			transform.position = new Vector2 (transform.position.x - bMoveSpeed, transform.position.y);
		}	
		if (Input.GetKeyDown(KeyCode.D)) 
		{
			transform.position = new Vector2 (transform.position.x + bMoveSpeed, transform.position.y);
		}	
	}

	void PlayerShoot()
	{
		/*if (Input.GetKeyDown (KeyCode.Mouse1)) 
		{
			Instantiate (Bullet, new Vector3(firePoint.transform.position.x, firePoint.transform.position.y,firePoint.transform.position.z), Quaternion.identity);
		}*/	
	}
}

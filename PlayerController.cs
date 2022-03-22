using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private SpriteRenderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		PlayerMovement ();
	}

	void PlayerMovement()
	{
		if (Input.GetKey(KeyCode.W)) 
		{
			transform.position = new Vector2 (transform.position.x, transform.position.y + moveSpeed);
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			transform.position = new Vector2 (transform.position.x, transform.position.y - moveSpeed);
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			transform.position = new Vector2 (transform.position.x - moveSpeed, transform.position.y);
			rend.flipX = true;
		}	
		if (Input.GetKey(KeyCode.D)) 
		{
			transform.position = new Vector2 (transform.position.x + moveSpeed, transform.position.y);
			rend.flipX = false;
		}	
	}
}

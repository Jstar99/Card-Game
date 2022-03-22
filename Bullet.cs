using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private Vector3 target;
	[SerializeField] private Camera mainCam;
	[SerializeField] private GameObject pellet;
	public GameObject player;

	public float bulletSpeed;
	public int bulletDamage = 10;

	public EnemyBattle enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		target = mainCam.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

		Vector3 difference = target - player.transform.position;
		float rotationZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
		player.transform.rotation = Quaternion.Euler (0.0f, 0.0f, rotationZ);

		if (Input.GetKeyDown (KeyCode.Mouse1)) 
		{
			float distance = difference.magnitude;
			Vector2 direction = difference / distance;
			direction.Normalize ();
			FireBullet (direction, rotationZ);
		}	
	}

	void FireBullet(Vector2 direction, float rotationZ)
	{
		GameObject b = Instantiate (pellet) as GameObject;
		b.transform.position = player.transform.position;
		b.transform.rotation = Quaternion.Euler (0.0f, 0.0f, rotationZ);
		b.GetComponent<Rigidbody2D> ().velocity = direction * bulletSpeed;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		 
		 
	}
}

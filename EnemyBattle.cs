using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBattle : MonoBehaviour {

	public float enemySpeed;
	public float accelerationTime = 2f;
	private Vector2 movement;
	private float timeLeft;

	private Rigidbody2D rb;

	private int enemyMaxHp;
	public int enemyCurrentHp;

	public GameObject enemyBullet;
	private float timeBtwShots;
	public float startTimeBtwShots;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		timeBtwShots = startTimeBtwShots;
	}
	
	// Update is called once per frame
	void Update () {
		EnemyMovement ();
		EnemyHealth ();
		EnemyFire ();
	}

	void FixedUpdate()
	{
		rb.AddForce (movement * enemySpeed);
	}

	void EnemyMovement()
	{
		timeLeft -= Time.deltaTime;
		if(timeLeft <= 0)
		{
			movement = new Vector2 (Random.Range (-1f, 1f), Random.Range (-1f, 1f));
			timeLeft += accelerationTime;
		}
	}

	void EnemyHealth()
	{
		if (enemyCurrentHp <= 0) 
		{
			Destroy (gameObject);
		}
	}

	public void EnemyFire()
	{
		if (timeBtwShots <= 0)
		{
			Instantiate (enemyBullet, transform.position, Quaternion.identity);
			timeBtwShots = startTimeBtwShots;
		}

		else
		{
			timeBtwShots -= Time.deltaTime;
		}
	}

}

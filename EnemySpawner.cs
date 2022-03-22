using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyObject;
	public Transform spawnPoint;
	private int randomNum;
	public float enemyMoveSpeed;

	public Transform[] moveSpots;
	private int randomSpot;

	// Use this for initialization
	void Start () {
		
		randomNum = Random.Range (1, 6);
		for(int i = 0; i <= randomNum; i++)
		{
			Instantiate (enemyObject, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y,spawnPoint.transform.position.z), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

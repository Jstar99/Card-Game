using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Deckbuilder : MonoBehaviour {

	[SerializeField] Text[] slot;
	private int nextSlot;

	// Use this for initialization
	void Start () {
		nextSlot = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChooseRedCard()
	{
		slot[nextSlot].text = "Red-Card"; 
		nextSlot += 1;
	}

	public void ChooseBlueCard()
	{
		slot[nextSlot].text = "Blue-Card"; 
		nextSlot += 1;
	}

	public void ChooseGreenCard()
	{
		slot[nextSlot].text = "Green-Card"; 
		nextSlot += 1;
	}

	public void StartOver()
	{		
		SceneManager.LoadScene (0);
	}

	public void StartGame()
	{
		SceneManager.LoadScene (1);
	}
}

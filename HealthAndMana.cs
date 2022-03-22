using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthAndMana : MonoBehaviour {

	public int numberOfCrystals;
	public int currentMana;
	public Image[] mana;
	public Sprite fullCrystal;
	public Sprite emptyCrystal;


	public Image healthBar;
	public Text healthText;
	private int maxHP;
	public int currentHP;

	void Start()
	{
	}

	void Update()
	{
		ManaSystem ();
		HealthSystem ();
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			currentHP -= 50;
		}
		if (Input.GetKeyDown (KeyCode.V)) 
		{
			currentHP += 50;
		}
	}

	void ManaSystem()
	{
		if (currentMana > numberOfCrystals)
		{
			currentMana = numberOfCrystals;
		}	

		for (int i = 0; i < mana.Length; i++) 
		{
			if(i < currentMana)
			{
				mana [i].sprite = fullCrystal;

			} 
			else
			{
				mana [i].sprite = emptyCrystal;	
			}


			if (i < numberOfCrystals) 
			{
				mana [i].enabled = true;	
			} 
			else
			{
				mana [i].enabled = false;	
			}
		}
	}


	void HealthSystem()
	{
		if (currentHP < 0) 
		{
			currentHP = 0;
		}

		healthBar.rectTransform.sizeDelta = new Vector2 (currentHP, 20.84f);

		healthText.text = currentHP.ToString();

		if (currentHP >= 330) 
		{
			healthBar.color = Color.green;
		}

		else if (currentHP >= 160 && currentHP < 330) 
		{
			healthBar.color = Color.yellow;
		}

		else if(currentHP < 160)
		{
			healthBar.color = Color.red;
		}
	}
}

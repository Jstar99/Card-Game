using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour {

	public Texture2D pointer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Cursor.SetCursor (pointer, Vector2.zero, CursorMode.ForceSoftware);
	}
}

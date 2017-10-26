using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject floor;
	public GameObject wall;
	public int mapWidth;
	public int mapHeight;

	// Use this for initialization
	void Start () {
		CreateLevel ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void CreateLevel(){
		Instantiate (floor);
		Instantiate (wall);

		for(int x = 0; x < mapWidth; x++){
			for(int y = 0; y < mapHeight; y++){

			}
		}
				
	}
}

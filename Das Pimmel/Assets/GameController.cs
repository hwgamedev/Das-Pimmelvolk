﻿using UnityEngine;
using System.Collections;


public class GameController : MonoBehaviour {
	public GameObject ground;
	public GameObject ceiling;
	public GameObject wall;
	public GameObject player;
	public GameObject enemy;
	public EnemyController enemies;
	public GameObject[,] walls;

	public int scale = 3;

	// Use this for initialization
	void Start () {
		Instantiate (ground);
		Instantiate (ceiling);
		loadLevel ("test");
		
		
		
		
	}

	void loadLevel(string path){
		//Load bitmap
		Texture2D testBMP = Resources.Load(path) as Texture2D;
		var width = testBMP.width;
		Debug.Log (width);
		var height = testBMP.height;
		Debug.Log (height);
		walls = new GameObject[width,height];

		for (int y = 0; y < height; y++)
		{
			for(int x = 0; x < width ; x++)
			{
				Color colour = testBMP.GetPixel(x, y);
				walls[x,y] = createWall(x,y,colour);
				
			}
		}

	} 

	GameObject createWall(int x, int z, Color c){
		
		if (c == Color.white)
		{
			return null;
		}
		else if (c == Color.blue)
		{
			player.transform.position = new Vector3(x * scale, 0.8f, z * scale);
			return null;
		}
		else if (c == Color.red)
		{
			enemy.tag = "Enemy";
			Instantiate(enemy, new Vector3(x * scale, 0f, z * scale), new Quaternion());
			return null;
		}
		else if (c == Color.black){
			return (GameObject)Instantiate(wall, new Vector3(x * scale, -1.5f, z * scale), new Quaternion());
		}
		return null;
		
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}

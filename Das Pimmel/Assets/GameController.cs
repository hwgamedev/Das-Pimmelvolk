using UnityEngine;
using System.Collections;


public class GameController : MonoBehaviour {
	public GameObject ground;
	public GameObject ceiling;
	public GameObject wall;

	public GameObject[] walls;

	public int scale = 3;

	// Use this for initialization
	void Start () {
		Instantiate (ground);
		Instantiate (ceiling);
		walls = new GameObject[100];
	
		walls [0] = createWall (0, 0);
		walls [1] = createWall (0, 1);
		walls [2] = createWall (0, 2);
		walls [3] = createWall (0, 3);
		walls [4] = createWall (1, 0);
		walls [5] = createWall (2, 0);
		walls [6] = createWall (3, 0);
		walls [7] = createWall (1, 0);
		walls [8] = createWall (3, 1);
		walls [9] = createWall (3, 2);
		walls [10] = createWall (3, 3);
		walls [10] = createWall (1, 3);
		walls [10] = createWall (2, 3);
		walls [10] = createWall (3, 3);
		wall = (GameObject)Instantiate (wall);




	}
	GameObject createWall(int x, int z){
		return (GameObject)Instantiate (wall, new Vector3 (x * 3, -1.5f, z * 3), new Quaternion ());
	}
	// Update is called once per frame
	void Update () {
	
	}
}

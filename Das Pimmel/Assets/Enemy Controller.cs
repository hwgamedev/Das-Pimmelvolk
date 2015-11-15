using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public GameObject enemy;

	
	public void addEnemy(int x,int z)
	{
		Instantiate(enemy, new Vector3(x , 0f, z), new Quaternion());
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}


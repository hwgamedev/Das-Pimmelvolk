using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int health = 100;
    private string name;
    private Object target;
    private Transform enemyTransform;
    private int rotationSpeed = 3;
    private int moveSpeed = 3;

	private void Start(){
	}


    public void createModel(int x, int z)
    {
        GameObject prefab = (GameObject)Resources.Load("Skeleton");
        Instantiate(prefab, new Vector3(x, -1.5f, z), new Quaternion());
    }

    public void updateHealth(int hitpoints)
    {
        this.health = this.health - hitpoints;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return this.name;
    }

    
	// Update is called once per frame
	private void Update ()
    {
        if (this.health > 0) {
			//enemyTransform.rotation = Quaternion.Slerp(enemyTransform.rotation, Quaternion.LookRotation(target.position - enemyTransform.position), rotationSpeed * Time.deltaTime);
			transform.position += transform.forward * moveSpeed * Time.deltaTime;

		} else {
			Destroy(this);
		}
	}
}

using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    private int health;
    private string name;

	// Use this for initialization
	void Start ()
    {
        //SetUp Mob
        setupMob(name);
	}

    public void setupMob(string name)
    {
        this.health = 100;
        setName(name);
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
	void Update () {
	
	}
}

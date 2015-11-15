using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    private int attack;
    private int defence;

	// Use this for initialization
	void Start ()
    {
        setupItem(attack, defence);
	}

    public void setupItem(int attack, int defence)
    {
        this.attack = attack;
        this.defence = defence;
    }

    public int getAttack()
    {
        return this.attack;
    }

    public int getDefence()
    {
        return this.defence;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

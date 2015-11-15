using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private int ammo;
    private int health;
    private ArrayList inventory = new ArrayList();
    private int maxCapacity;
    private int maxAmmo;
    private int maxHealth;

	// Use this for initialization
	void Start ()
    {
        setUpChar();
	}

    public void setUpChar()
    {
        this.health = 100;
        this.ammo = 100;
        this.maxCapacity = 5;
    }

    //GETTER METHODS FOR PRIVATE VARIABLES
    public int getAmmo()
    {
        return this.ammo;
    }

    public int getHealth()
    {
        return this.health;
    }

    public int getCap()
    {
        return this.maxCapacity;
    }

    //UPDATE AMMO AND HEALTH
    public void updateAmmo(int ammoUpdate)
    {
        if(!(getAmmo()+ammoUpdate > maxAmmo))
        {
            this.ammo = this.ammo - ammoUpdate;
            if(this.ammo < 0)
            {
                //OUT OF AMMO
                this.ammo = 0;
            }
        }
        else
        {
            //MESSAGE HERE
        }
    }

    public void updateHealth(int healthUpdate)
    {
        if(!(getHealth()+healthUpdate > maxHealth))
        {
            this.health = this.health + healthUpdate;
            if (this.health < 0)
            {
                //DEAD
            }
        }
    }

    //
    public void checkInv()
    {
        foreach( var i in inventory)
        {
            //MESSAGE HERE
        }
    }

    public void addItemInv(object item)
    {
        //If adding would not go over max, add item
        if (!(inventory.Count + 1 > getCap()))
        {
            inventory.Add(item);
        }
        else
        {
            //MESSAGE HERE
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

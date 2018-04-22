﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int enemyHealth;
    public GameObject deathEffect;
    public int pointsOnDeath;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(enemyHealth <= 0)
        {
            //Obj destroy
            Destroy(gameObject);
        }
	}

    public void giveDmg(int damageToGive)
    {
        enemyHealth -= damageToGive;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public const int maxHealth = 100;
	public int currentHealth = maxHealth;
	public RectTransform healthbar;

	public void TakeDamage(int amount){
		currentHealth -= amount/2;

		Debug.Log ("Damage Taken");

		if (currentHealth <= 0) {
			Debug.Log ("dead");
		}

		healthbar.sizeDelta = new Vector2 (currentHealth*2, healthbar.sizeDelta.y);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

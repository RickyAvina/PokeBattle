using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;

	public GameObject myText;
	private Text fooText;

	public void Start(){
		fooText = myText.GetComponent<Text> ();
		fooText.text = "";
	}
		
	public void LateUpdate(){
		if (player2.GetComponent<Health> ().currentHealth <= 0) {
			fooText.text = "player 1 wins";
		} else if (player1.GetComponent<Health> ().currentHealth <= 0) {
			fooText.text = "Player 2 wins";
		}	
	}
}

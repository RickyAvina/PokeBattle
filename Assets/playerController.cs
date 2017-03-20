using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerController : MonoBehaviour {

	public GameObject energyBallPrefab;
	public Transform ballSpawn;
	public Transform nidoBallSpawn;
	public GameObject playerInfo;

	public GameObject mewtwo;
	public GameObject nidoking;

	public string myName = "";
	public string currentPokemonName;

	private Transform spawnLoc;

	// Use this for initialization
	void Start () {
		Debug.LogError ("PAYY ATTENTION");
	    myName = playerInfo.GetComponent<SetupLocalPlayer>().pname;
		Debug.Log("My name is " + myName);
		currentPokemonName = GameObject.Find ("Player(Clone)").GetComponent<SetupLocalPlayer> ().pname;
	}
	
	// Update is called once per frame

	public void OnFireButon(){

		Debug.Log ("The current pokeman is: " + currentPokemonName);
		if (currentPokemonName == "mewtwo") {
			GameObject energyBall = (GameObject)Instantiate (energyBallPrefab, ballSpawn.position, ballSpawn.rotation);
			energyBall.GetComponent<Rigidbody>().velocity = energyBall.transform.up * 1000.0f;
			Debug.Log ("Mewtwo chosen");
		} else if (currentPokemonName == "nidoking") {
			GameObject energyBall = (GameObject)Instantiate (energyBallPrefab, nidoBallSpawn.position, nidoBallSpawn.rotation);
			energyBall.GetComponent<Rigidbody>().velocity = energyBall.transform.forward * 1000.0f;				
			Debug.Log ("Nidoking chosen");
		} else {
			GameObject energyBall = (GameObject)Instantiate (energyBallPrefab, ballSpawn.position, ballSpawn.rotation);
			energyBall.GetComponent<Rigidbody>().velocity = energyBall.transform.up * 1000.0f;
			Debug.Log ("Mewtwo chosen");
		}
	}

	public void OnEnemyFire(){
		GameObject newBall = (GameObject)Instantiate (energyBallPrefab, nidoBallSpawn.position, nidoBallSpawn.rotation);
		newBall.GetComponent<Rigidbody> ().velocity = newBall.transform.forward * 1000.0f;
	}

	void Update () {
		/*if (Input.GetKeyDown (KeyCode.Space)) {
			string currentPokemonName = GameObject.Find ("Player(Clone)").GetComponent<SetupLocalPlayer> ().pname;

			Debug.Log ("The current pokeman is: " + currentPokemonName);
			if (currentPokemonName == "mewtwo") {
				GameObject energyBall = (GameObject)Instantiate (energyBallPrefab, mewtwo.transform.position, mewtwo.transform.rotation);
				energyBall.GetComponent<Rigidbody>().velocity = energyBall.transform.up * 600.0f;
				Debug.Log ("Mewtwo chosen");
			} else if (currentPokemonName == "nidoking") {
				GameObject energyBall = (GameObject)Instantiate (energyBallPrefab, nidoBallSpawn.position, nidoBallSpawn.rotation);
				energyBall.GetComponent<Rigidbody>().velocity = energyBall.transform.forward * 600.0f;				
				Debug.Log ("Nidoking chosen");
			} else {
				Debug.LogError ("None chosen!");
			}

			//GameObject energyBall = (GameObject)Instantiate (energyBallPrefab, nidoking.transform.position, nidoking.transform.rotation);

			//energyBall.GetComponent<Rigidbody>().velocity = energyBall.transform.up * 600.0f;			//Debug.Log (energyBall.GetComponent<Rigidbody>().velocity);
		//	Destroy (energyBall, 4);
		}*/
	}

	public void updateName(string name){
		myName = name;
		Debug.Log ("My name is now: " + myName);
	}
}

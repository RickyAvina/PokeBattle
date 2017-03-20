using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerScript : NetworkBehaviour {

	public GameObject energyBallPrefab;
	public Transform energyBallSpawn;
	public GameObject playerInfo;
	public Transform nidoEnergySpawn;

	public GameObject mewtwo;
	public GameObject nidoking;

	public Transform spawningPoint;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) {
			return;
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			CmdFire ();
		}
	}

	void LateUpdate(){

	}

	[Command]
	void CmdFire(){
		// create energy ball

		Debug.Log ("AYY: " + playerInfo.GetComponent<SetupLocalPlayer> ().pname);

		if (GameObject.Find("Player(Clone)").GetComponent<SetupLocalPlayer> ().pname == "mewtwo") {
			spawningPoint = mewtwo.transform;
		} else if (GameObject.Find("Player(Clone)").GetComponent<SetupLocalPlayer> ().pname == "nidoking") {
			spawningPoint = nidoking.transform;
		} else {
			Debug.LogError ("Neither!");
		}

		GameObject energyBall = (GameObject)Instantiate(energyBallPrefab, spawningPoint.position, spawningPoint.rotation);

		// add velocity
		energyBall.GetComponent<Rigidbody>().velocity = energyBall.transform.forward * 6.0f;

		// spawn bullet on client
		NetworkServer.Spawn(energyBall);

		// Destroy after 2 seconds
		Destroy(energyBall, 2);
	}
}

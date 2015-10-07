using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {
	public OreType myType = OreType.Bronze;

	// Use this for initialization
	void Start () {
		if (myType == OreType.Bronze) {
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
		else if (myType == OreType.Silver) {
			gameObject.GetComponent<Renderer>().material.color = Color.white;
		}
		else if (myType == OreType.Gold) {
			gameObject.GetComponent<Renderer>().material.color = Color.yellow;
		}
	}

	void OnMouseDown () {
		DestroyObject (gameObject);

		if (myType == OreType.Bronze) {
			GameControllerScript.bronzeCount--;
			GameControllerScript.score += GameControllerScript.bronzePoints;
		} 
		else if (myType == OreType.Silver) {
			GameControllerScript.silverCount--;
			GameControllerScript.score += GameControllerScript.silverPoints;
		} 
		else if (myType == OreType.Gold) {
			GameControllerScript.goldCount--;
			GameControllerScript.score += GameControllerScript.goldPoints;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}

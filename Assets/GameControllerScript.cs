using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
	public GameObject cubePrefab;
		float spawnTime = 3.0f;
		float timeToAct = 0.0f;
		float spawnSilverTime = 12.0f;
		float stopSpawningTime = 6.0f;

	public GameObject bronzePrefabCube;
	public GameObject silverPrefabCube;
	public GameObject goldPrefabCube;
	public static int bronzeCount = 0;
	public static int silverCount = 0;
	public static int goldCount = 0;
	public static int bronzePoints = 1;
	public static int silverPoints = 10;
	public static int goldPoints = 100;
	public static int score = 0;
	private bool recentlySpawnedGold = false; 

	// Use this for initialization
	void Start () {
		timeToAct += spawnTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= timeToAct) {

			//Check to spawn gold first
			// dont spawn gold twice in a row
			if (bronzeCount == 2 && silverCount == 2 && recentlySpawnedGold == false) {
				Instantiate(goldPrefabCube,
				            new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
				            Quaternion.identity);
				goldCount++;
				recentlySpawnedGold = true;
			}

			else if (bronzeCount < 4) {
				Instantiate(bronzePrefabCube,
				            new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
				            Quaternion.identity);
				bronzeCount++;
				recentlySpawnedGold = false;
			}

			else if (bronzeCount >= 4) {
				Instantiate(silverPrefabCube,
				            new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
				            Quaternion.identity);
				silverCount++;
				recentlySpawnedGold = false;
			}

			timeToAct += spawnTime;
		}
	}}
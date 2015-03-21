using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	static int screenWidth = 1280;
	static int screenHeight = 800;
	static int screenSize = screenWidth * screenHeight;
	
	static float obstacleMinSpeed = 0.1f;
	static float obstacleMaxSpeed = 3;
	static float obstacleMinRadius = 40;
	static float obstacleMaxRadius = 200;
	static int obstacleSpawnPeriodMin = (int) (60000000 / (float) screenSize); //60; 
	static int obstacleSpawnPeriodMax = (int) (300000000 / (float) screenSize);//300;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}

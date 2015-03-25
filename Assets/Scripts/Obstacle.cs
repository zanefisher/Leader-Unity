using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	static float obstacleMinSpeed = 0.1f;
	static float obstacleMaxSpeed = 3;
	static float obstacleMinRadius = 40;
	static float obstacleMaxRadius = 200;
	static int obstacleSpawnPeriodMin = (int) (60000000 / (float) Controller.screenSize); //60; 
	static int obstacleSpawnPeriodMax = (int) (300000000 / (float) Controller.screenSize);//300;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

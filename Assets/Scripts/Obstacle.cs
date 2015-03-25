using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	public static float obstacleMinSpeed = 0.1f;
	public static float obstacleMaxSpeed = 3;
	public static float obstacleMinRadius = 40;
	public static float obstacleMaxRadius = 200;
	public static int obstacleSpawnPeriodMin = (int) (60000000 / (float) Controller.screenSize); //60; 
	public static int obstacleSpawnPeriodMax = (int) (300000000 / (float) Controller.screenSize);//300;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

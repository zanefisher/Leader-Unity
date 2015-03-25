using UnityEngine;
using System.Collections;

public class Swarmling : MonoBehaviour {
	public static int initSwarmCount = 8;
	//color swarmlingColor = color(82, 68, 48);
	public static float swarmlingRadius = 5;
	public static float swarmlingMaxSpeed = 3.8f;
	public static float swarmlingDriftSpeed = 0.6f;
	public static float swarmlingMaxAccel = 0.3f;
	public static float swarmlingDamage = 0.05f;
	public static float avoidRadius = 80;
	public static float lineElbowRadius = 15;
	public static float elbowRadius = 40;
	public static float burnRadius = 100;
	public static float attractRadius = 60;
	private  float x, y, dx, dy, targetDistance;
	public Obstacle target;
	public Swarmling following;
	private bool unan = true;
	private int followCooldown = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

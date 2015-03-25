using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	public static float obstacleMinSpeed = 0.1f;
	public static float obstacleMaxSpeed = 3;
	public static float obstacleMinRadius = 40;
	public static float obstacleMaxRadius = 200;
	public static int obstacleSpawnPeriodMin = (int) (60000000 / (float) Controller.screenSize); //60; 
	public static int obstacleSpawnPeriodMax = (int) (300000000 / (float) Controller.screenSize);//300;
	private float lifePoint=2f;
	private bool isMoving=true;
	public GameObject World;
	//private bool isEntrance=false;
	// Use this for initialization
	void Start () {
		lifePoint = transform.localScale.x;
		//should have set the moving bool to indicate the
	}
	
	// Update is called once per frame
	void Update () {
		vanish ();
	}

	void vanish(){
		if (lifePoint <= 0) {
			DestroyObject(this);
		}
		if ((transform.position - World.transform.position).magnitude > 30f) {
			DestroyObject(this);
		}
	}

	void onTriggerEnter2D(Collision2D coll){
		if (coll.gameObject.name == "Swamling") {
			lifePoint-=0.5f;
			//DestroyObject(coll);
		}
	}

	void showEntrance(){
		if (isMoving) {
		}
	}
	
}

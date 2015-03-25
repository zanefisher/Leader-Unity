using UnityEngine;
using System.Collections;



public class World : MonoBehaviour {
	
	public const int numOfSwarmlings = 20;
	float worldRadius = 15f;
	public Transform Swarmling;
	
	// Use this for initialization
	void Start () {
		generateSwarmling (numOfSwarmlings, new Vector2 (0, 0), worldRadius);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void generateSwarmling(int swarmlingCount, Vector2 center, float radius){
		
		
		for (int i=0; i<swarmlingCount; i++) {
			Vector2 newPos = Random.insideUnitCircle * radius;
			newPos = new Vector2 (newPos.x + center.x, newPos.y + center.y);
			
			Instantiate(Swarmling, new Vector3(newPos.x,newPos.y,0), Quaternion.identity);
		}
	}
	
}

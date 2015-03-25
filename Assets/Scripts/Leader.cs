using UnityEngine;
using System.Collections;

public class Leader : MonoBehaviour {
	float speed=5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		targetPos = new Vector3(targetPos.x, targetPos.y, 0);
		if(targetPos != transform.position)
			transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

	}
}

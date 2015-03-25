using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public GameObject me;
	public Vector3 size;
	public Vector3 here;

	float montecarlo(float max){
		
		bool sign = true;
		
		while(true){
			
			float value = Random.Range(0f, max);
			float check = Random.Range(0f, max);
			
			if(value <= check){
				
				if(Random.value < 0.5f)
					sign = !sign;
				
				value *= sign ? 1f : -1f;
				
				return value;
				
			}
		}
	}

	Vector3 position(){

		float radians = Random.value * 2 * Mathf.PI;

		here = new Vector3(transform.position.x + Mathf.Sin(radians) * 25f,	transform.position.y + Mathf.Cos(radians) * 25f, transform.position.z);
		
		return here;
		
	}

	Vector3 scale(){
		
		float value = 2f + montecarlo(1.5f);
		size = new Vector3(value, value, 1f);
		
		return size;
		
	}


	void Start () {

		StartCoroutine("Spawn");

	}
	
	IEnumerator Spawn(){
		
		while(true){

			here = position();
			float radians = montecarlo(45f) * Mathf.Deg2Rad;
			GameObject clone = Instantiate(me, here, Quaternion.identity) as GameObject;
			clone.transform.parent = gameObject.transform;
			clone.transform.localScale = scale();
			clone.GetComponent<Rigidbody2D>().velocity =
				(-clone.transform.position + transform.position + new Vector3(Mathf.Sin(radians), Mathf.Cos(radians), 0f)).normalized;



			yield return new WaitForSeconds(3f + montecarlo(2f));

		}
	}
}

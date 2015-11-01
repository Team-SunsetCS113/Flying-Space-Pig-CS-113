using UnityEngine;
using System.Collections;

public class BGLooperScript : MonoBehaviour {

	// Use this for initialization
	int numBGImages = 3;
	void OnTriggerEnter2D(Collider2D collision){
		Debug.Log ("Triggered: Object collided" + collision.name);

		float widthOfObject = ((BoxCollider2D)collision).size.x;
		Vector3 pos = collision.transform.position;
		pos.x += widthOfObject * numBGImages;
		collision.transform.position = pos;
	}


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	float speed = 5f;
	float tilt = 5f;
    
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void FixedUpdate () {
		float dirX = Input.GetAxis ("Horizontal");	
		float dirY = Input.GetAxis ("Vertical");	

		Vector3 movement = new Vector3 (dirX, 0, dirY);
        //
		GetComponent<Rigidbody> ().velocity = movement * speed;	// 방향 * 스피드
		GetComponent<Rigidbody> ().rotation = Quaternion.Euler (0, 0, GetComponent<Rigidbody> ().velocity.x * -tilt);	// 회전
        
	}
}

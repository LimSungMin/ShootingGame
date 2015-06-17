using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	float speed = 5f;
	float tilt = 5f;
    public GameObject m_shot;           // 총알 메쉬
    public Transform m_firePosition;    // 총알이 시작되는 위치
	// Use this for initialization
	void Start () {

	}

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){   // Left Controll
            Instantiate(m_shot, m_firePosition.position, m_firePosition.rotation);
        }
    }

	// Update is called once per frame
	void FixedUpdate () {
		float dirX = Input.GetAxis ("Horizontal");	
		float dirY = Input.GetAxis ("Vertical");	

		Vector3 movement = new Vector3 (dirX, 0, dirY);

		GetComponent<Rigidbody> ().velocity = movement * speed;	// 방향 * 스피드
		GetComponent<Rigidbody> ().rotation = Quaternion.Euler (0, 0, GetComponent<Rigidbody> ().velocity.x * -tilt);	// 회전
        
	}

    
}

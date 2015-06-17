using UnityEngine;
using System.Collections;

public class DestroyByContent : MonoBehaviour
{
    public GameObject explosion;

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")    // 적들끼리 부딫혔을때
            return;

        Instantiate(explosion, transform.position, transform.rotation);        
        Destroy(gameObject);        // 운석
        Destroy(other.gameObject);  // 운석과 부딫힌것
    }
}

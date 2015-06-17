using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

    public GameObject m_shot;
    public Transform m_firePosition;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Fire", 1, 2);
	}

    void Fire()
    {
        Instantiate(m_shot, m_firePosition.position, m_firePosition.rotation);
    }
}

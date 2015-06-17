using UnityEngine;
using System.Collections;

public class RandomRotate : MonoBehaviour
{
    float tumble = 5f;   // 회전하는 값
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;   // 랜덤한 값으로 운석을 회전

    }
}

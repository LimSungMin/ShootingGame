using UnityEngine;
using System.Collections;

public class DestroyByContent : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    GameObject GameController;
	// Use this for initialization
	void Start () {
        GameController = GameObject.Find("GameController");
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")    // 적들끼리 부딫혔을때
        {
            return;
        }
                    
        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (other.tag == "Player")  // 만약 부딫힌게 플레이어 라면
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);   // 플레이어 위치에 파티클과 사운드 출력
            GameController.GetComponent<GameController>().GameOver();
        }

        
        GameController.GetComponent<GameController>().AddScore(10);

        Destroy(gameObject);        // 운석
        Destroy(other.gameObject);  // 운석과 부딫힌것
    }
}

using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject[] hazards;
    public float m_startWait = 1;
    public float m_spawnWait = 1.5f;
    public float m_waveWait = 2;
	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnWaves());        
	}
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(m_startWait); // m_startWait 초 대기 후 함수 작동

        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-5, 5), 5, 16);
                Quaternion spawnRotation = Quaternion.Euler(new Vector3(0, 180, 0));
                Instantiate(hazard, spawnPosition, spawnRotation);

                yield return new WaitForSeconds(m_spawnWait);
            }

            yield return new WaitForSeconds(m_waveWait);
        }
        
        
    }
	// Update is called once per frame
	void Update () {
	
	}
}

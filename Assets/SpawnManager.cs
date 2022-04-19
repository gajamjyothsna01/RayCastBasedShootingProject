using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.P))
        {
            Vector3 enemyPosition = new Vector3(Random.Range(-10,11), 5, Random.Range(10,11));
            Instantiate(enemyPrefab,enemyPosition,Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeadEnemy()
    {
        Debug.Log("Enemy Dead");
        Destroy(gameObject);
        //GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Score(10);
       
    }
}

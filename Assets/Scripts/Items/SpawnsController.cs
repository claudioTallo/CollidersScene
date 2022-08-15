using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnsController : MonoBehaviour
{
    [SerializeField]
    Transform[] spawnPositions;
    int spawnPositionIndex = 0;

    private float timeInWall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
    if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log(" EN EL TRIGGER ->" + other.gameObject.name);
            timeInWall+= Time.deltaTime;
            Debug.Log(timeInWall);
            if (timeInWall >= 2)
            {
                spawnPositionIndex = Random.Range(0, spawnPositions.Length);
                
                transform.position = spawnPositions[spawnPositionIndex].position;
                transform.rotation = spawnPositions[spawnPositionIndex].rotation;
                //spawnPositionIndex += 1;
                timeInWall = 0;
            }
            
        }
    }
}

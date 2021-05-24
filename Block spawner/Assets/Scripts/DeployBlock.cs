using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBlock : MonoBehaviour
{
    public GameObject blockPrefab;
    public float respawnTime = 3;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(blockSpawning());
    }
    private void spawnBlock()
    {
        GameObject a = Instantiate(blockPrefab) as GameObject;
        //change values in the a.transform.position to alter spawn area
        a.transform.position = new Vector3(Random.Range(-20f, -10f), Random.Range(1f,5f), Random.Range(-10f, 10f));
    }


    //spawn blocks every 'respawnTime' seconds
    IEnumerator blockSpawning()
    {
        //while (true)
        while (true)
        {
                yield return new WaitForSeconds(respawnTime);
                spawnBlock();
        }
    }
}
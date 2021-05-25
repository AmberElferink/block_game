using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBlock : MonoBehaviour
{
    public GameObject blockPrefab;
    public float shipSpawnTime1 = 1.5f;
    public float shipSpawnTime2 = 1.0f;
    public float lampraySpawnTime = 4.0f;

    private GameObject canvas;


    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(blockSpawning());
        canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);    
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
        yield return new WaitForSeconds(10);        
        //followed video https://www.youtube.com/watch?v=7OEth2NdXnU
        //started at 7:57
        spawnBlock();
        yield return new WaitForSeconds(shipSpawnTime1);
        spawnBlock();       
        yield return new WaitForSeconds(shipSpawnTime1);
        spawnBlock();      
        yield return new WaitForSeconds(shipSpawnTime1);
        spawnBlock();
        yield return new WaitForSeconds(shipSpawnTime1);
        spawnBlock(); 
        //8:06
        yield return new WaitForSeconds(17);
        //lamprays
        //8:23 
        spawnBlock();
        yield return new WaitForSeconds(lampraySpawnTime);
        spawnBlock(); //8:27
        yield return new WaitForSeconds(lampraySpawnTime);
        spawnBlock(); //8:31 
        yield return new WaitForSeconds(9);   
        //8:40 ships
        spawnBlock(); //8:40
        yield return new WaitForSeconds(shipSpawnTime1);
        spawnBlock(); //8:42
        yield return new WaitForSeconds(shipSpawnTime2);  
        spawnBlock(); //8:43
        yield return new WaitForSeconds(shipSpawnTime2);  
        spawnBlock(); //8:44
        yield return new WaitForSeconds(shipSpawnTime2);   
        spawnBlock(); //8:45

        yield return new WaitForSeconds(4);   
        spawnBlock(); //8:49
        yield return new WaitForSeconds(7);   
        spawnBlock(); //8:56
        yield return new WaitForSeconds(14);

        //tongue
        spawnBlock(); //9:10
        yield return new WaitForSeconds(shipSpawnTime1);
        spawnBlock(); //9:10
        yield return new WaitForSeconds(5);

        //free hit cthulu
        spawnBlock(); //9:15
        yield return new WaitForSeconds(1);
        spawnBlock(); 
        yield return new WaitForSeconds(1);
        spawnBlock(); 
        yield return new WaitForSeconds(1);
        spawnBlock(); 
        yield return new WaitForSeconds(1);
        spawnBlock();
        yield return new WaitForSeconds(1);
        spawnBlock(); 

        //9:21
        yield return new WaitForSeconds(9);

        //9:30 lamprays
        spawnBlock(); 
        yield return new WaitForSeconds(4);
        spawnBlock(); 
        yield return new WaitForSeconds(2);
        spawnBlock(); 
        yield return new WaitForSeconds(1);
        spawnBlock();
        //9:37

        yield return new WaitForSeconds(8);
        //9:45, ships
        spawnBlock();         
        yield return new WaitForSeconds(1);
        spawnBlock(); 
        yield return new WaitForSeconds(2);
        spawnBlock(); //9:48
        yield return new WaitForSeconds(2);
        spawnBlock();//9:50
        yield return new WaitForSeconds(3);
        spawnBlock(); //9:53
        yield return new WaitForSeconds(1);
        spawnBlock(); //9:54   
        yield return new WaitForSeconds(4);
        spawnBlock(); //9:58 boulder 

        //10:12 tongue
        spawnBlock();         
        yield return new WaitForSeconds(1);
        spawnBlock(); 
        yield return new WaitForSeconds(1);
        spawnBlock(); //10:14
        yield return new WaitForSeconds(1);
        spawnBlock();//10:15       
        yield return new WaitForSeconds(1);
        spawnBlock();//10:16 

        yield return new WaitForSeconds(6);

        //10:22 free hit cthulu
        spawnBlock();         
        yield return new WaitForSeconds(1);
        spawnBlock(); 
        yield return new WaitForSeconds(0.5f);
        spawnBlock();
        yield return new WaitForSeconds(0.5f);
        spawnBlock();     
        yield return new WaitForSeconds(0.5f);
        spawnBlock(); 
        yield return new WaitForSeconds(0.5f);
        spawnBlock();      
        yield return new WaitForSeconds(0.5f);
        spawnBlock();     
        //10:26
        
        yield return new WaitForSeconds(5.0f);

        canvas.SetActive(true);              
    }
}
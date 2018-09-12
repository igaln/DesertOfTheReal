using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landscape : MonoBehaviour {

    public GameObject floorTile;
    public int floorWidth = 15;
    public int floorHeight = 15;

    public float heightScale = 1.0F;
    public float xScale = 10.0F;

   

	void Start () {

       

        for (int k = 0; k < floorWidth; k++) {
            for (int z = 0; z < floorHeight; z++) {
                
                GameObject newTile = Instantiate<GameObject>(floorTile);
                float height = heightScale * Mathf.PerlinNoise(k * xScale * (Time.deltaTime), heightScale * z * (Time.deltaTime));
                newTile.transform.position = new Vector3(k, height, z);
                newTile.name = "tile_" + (k * floorWidth) + z;

            }
        }
	}


    void Update()
    {

     
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTileMap : MonoBehaviour {

    public TypeTiles[] tipoTiles;

    int[,] tiles;

    public int filasZ;
    public int columnasX;

	// Use this for initialization
	void Start () {

        tiles = new int[filasZ,columnasX];

        for (int i = 0; i < filasZ; i++)
        {
            for (int j = 0; j < columnasX; j++)
            {
                tiles[i, j] = 0;
            }
        }

        tiles[8, 0] = 1;
        tiles[8, 1] = 1;
        tiles[8, 2] = 1;

        tiles[9, 0] = 1;
        tiles[9, 1] = 1;
        tiles[9, 2] = 1;
        tiles[9, 3] = 1;
        tiles[9, 4] = 1;
        tiles[9, 5] = 1;
        tiles[9, 6] = 1;

        tiles[4, 3] = 2;
        tiles[4, 4] = 2;
        tiles[4, 5] = 2;
        tiles[3, 3] = 2;
        tiles[3, 4] = 2;


        GeneradorTileMap();
    }
	


    void GeneradorTileMap()
    {
        for (int i = 0; i < filasZ; i++)
        {
            for (int j = 0; j < columnasX; j++)
            {
                TypeTiles tt = tipoTiles[tiles[i, j]];
                Instantiate(tt.tilePrefab, new Vector3(j, -1, i), Quaternion.identity);
            }
        }
    }


	// Update is called once per frame
	void Update () {
        
	}
}

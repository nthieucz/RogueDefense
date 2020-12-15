using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public MapInfo mapInfo;
    private int mapWidth;
    private int mapHeight;
    private float mapCellSize;

    public GameObject player;

    private void Start()
    {
        mapWidth = mapInfo.width;
        mapHeight = mapInfo.height;
        mapCellSize = mapInfo.cellSize;
        GameObject.Instantiate(player, new Vector3(mapWidth/2, mapHeight/2), new Quaternion());
    }
}

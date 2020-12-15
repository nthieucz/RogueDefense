using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject horizontalWall;
    public GameObject verticalWall;
    private Grid grid;
    public MapInfo mapInfo;

    private int width;
    private int height;
    private float cellSize;

    // Start is called before the first frame update
    void Start()
    {
        width = mapInfo.width;
        height = mapInfo.height;
        cellSize = mapInfo.cellSize;
        grid = new Grid(width, height, cellSize);
        generateWalls(width, height, cellSize);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(getMousePosition(), 1);
        }
        */
        
    }

    public static Vector3 getMousePositionZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }
    //return mouse positon in world with z = 0f;
    public static Vector3 getMousePosition()
    {
        Vector3 vec = getMousePositionZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }
    //Works only on square
    public void generateWalls(int width, int height, float cellSize)
    {
        horizontalWall.transform.localScale = new Vector3(width * cellSize, 1);
        verticalWall.transform.localScale = new Vector3(1, height * cellSize);
        GameObject.Instantiate(horizontalWall, new Vector3(width * cellSize / 2, -0.5f), new Quaternion());
        GameObject.Instantiate(horizontalWall, new Vector3(width * cellSize / 2, height*cellSize+0.5f), new Quaternion());
        GameObject.Instantiate(verticalWall, new Vector3(-0.5f, height*cellSize/2), new Quaternion());
        GameObject.Instantiate(verticalWall, new Vector3(width*cellSize + 0.5f, height * cellSize / 2), new Quaternion());
    }
}

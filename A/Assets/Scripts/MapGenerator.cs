using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    public GameObject tile;
    public Camera cam;
    public Transform canvas;

    private int columnLength=10;
    private int rowLength=10;

    private float xLength;
    private float yLength;



    private void Start()
    {
        Vector2 center = canvas.position;
        xLength = tile.GetComponent<RectTransform>().sizeDelta.x -5;
        yLength = tile.GetComponent<RectTransform>().sizeDelta.y -5;

        float xstart = (rowLength / 2 - 0.5f)*xLength;
        float ystart = (columnLength / 2 - 0.5f) * yLength;
        Vector2 start = center - new Vector2(xstart, ystart);
        Debug.Log(start);

        for (int x=0; x<rowLength; x++)
        {
            for(int y=0; y<columnLength; y++)
            {
                GameObject.Instantiate(tile, start + new Vector2(x * xLength, y * yLength), Quaternion.identity, canvas);
                
            }
        }
    }
}

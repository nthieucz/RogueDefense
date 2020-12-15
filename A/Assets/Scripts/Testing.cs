using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    private Grid grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid(5, 5, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(getMousePosition(), 1);
        }
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
}

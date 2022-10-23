using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctagonScale : MonoBehaviour
{
    public Vector2 scaleChange = new Vector2(1,1);
    public Vector2 gridSize;
    public GameObject octagonGrid;
    public bool isScale;
    public bool isClone;
    // Start is called before the first frame update
    void Start()
    {       
        if (isClone)
        {
            for (int x = 0; x < gridSize.x; x++)
            {
                for (int y = 0; y < gridSize.y; y++)
                {
                    GameObject tile = Instantiate(octagonGrid);
                    tile.transform.position = new Vector2(x, y);
                    Debug.Log(x + "," + y);
                    if (isScale)
                    {
                        float degree = Mathf.PI / 4;
                        float scaled = 1 / Mathf.Cos(degree);
                        tile.transform.localScale = scaleChange * scaled;
                    }
                }
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

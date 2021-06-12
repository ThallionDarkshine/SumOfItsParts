using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Selection : MonoBehaviour
{
    public Camera camera;
    public Tile selectorTile;
    public Tilemap overlayTilemap;
    public int tmWidth, tmHeight;

    private Vector3Int selected;
    private bool isSelected = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (isSelected) {
                overlayTilemap.SetTile(selected, null);
            }

            Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selected = overlayTilemap.WorldToCell(point);
            isSelected = true;
            overlayTilemap.SetTile(selected, selectorTile);
        }
    }
}

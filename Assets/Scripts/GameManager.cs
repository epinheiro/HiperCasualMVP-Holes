using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isDebug;

    public GameObject quadColliderPrefab;

    public GameObject playerReference;

    public GameObject safetyNet;
    [Range(1,500)] public int gridSize;

    GameObject[,] grid;

    private void instantiateGrid(){
        int halfGridSize = gridSize/2;
        int coordNegative = -halfGridSize;
        int coordPositive =  halfGridSize;

        grid = new GameObject[gridSize,gridSize];

        GameObject group = new GameObject("GridGroup");
        group.transform.parent = this.transform.parent;

        for ( int i = coordNegative; i < coordPositive; i++ ) {
            for ( int j = coordNegative; j < coordPositive; j++ ) {
                int x = i + halfGridSize;
                int y = j + halfGridSize;

                GameObject newQuad = Instantiate(quadColliderPrefab, new Vector3(i, 0, j), Quaternion.AngleAxis(90, Vector3.right));
                
                if (isDebug){
                    newQuad.GetComponent<QuadController>().isDebug = this.isDebug;
                }

                newQuad.name = string.Format("Quad({0},{1})", x, y);
                newQuad.transform.parent = group.transform;

                grid[x, y] = newQuad;
            }
        }
    }

    private void instantiateSafetyNet(){
        GameObject group = new GameObject("background");
        group.transform.parent = this.transform.parent;

        GameObject plane = Instantiate(safetyNet, new Vector3(0, 0, 0), Quaternion.identity); //safetyNet
        plane.transform.parent = group.transform;

        Vector3 localScale = plane.transform.localScale;
        plane.transform.localScale = localScale * (gridSize/10);

        plane.transform.position = new Vector3(-0.5F, -5F, -0.5F);

        plane.GetComponent<Renderer>().material.color = Color.black;

        plane.GetComponent<SafetNetController>().playerReference = this.playerReference;

    }

    void Awake() {
        instantiateGrid();
        instantiateSafetyNet();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}

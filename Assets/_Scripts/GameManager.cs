using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int width = 8;
    public int height = 8;

    void Start()
    {
        Debug.Log("Game Started");
        CreateGrid();
    }

    void CreateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Debug.Log("Tile created at: " + x + "," + y);
            }
        }
    }
}

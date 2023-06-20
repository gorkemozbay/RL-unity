using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        spawnBlocks();
    }

    public int height, width;
    public GameObject block;
    void spawnBlocks() 
    {
        for (int x = 0; x < height; x++) 
        { 
            for (int z = 0; z < width; z++) 
            {
                Instantiate(block, new Vector3(x, 0, z), Quaternion.identity);
            }
        }
    }

}

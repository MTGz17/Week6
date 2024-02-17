using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week6 : MonoBehaviour
{

    public int sizeOfForest;
    public int stonesRequired;
    public GameObject floor;
    public GameObject [] trees;
    public GameObject [] stones;
    int xpos;



    void Start()
    {
        InitializeVariable();
        CreateGround();
        CreateRandomForest();
        CreatePyramid();
    }

    void InitializeVariable()
    {
        Vector3 worldOrigin = new Vector3(0, 0, 0);
        Vector3 randomTreeSpawnPosition = new Vector3(Random.Range(-10,11), 1, Random.Range(-10,11));
        Vector3 pyramid = new Vector3(x+10, height+.5f, z);
    }
    void CreateGround()
    {
        Vector3 worldOrigin = new Vector3(0, 0, 0);
        Instantiate(floor, worldOrigin, Quaternion.identity);
    }


    void CreateRandomForest()
    {
    for (int i = 0; i < (sizeOfForest); i++)
        {
        Vector3 randomTreeSpawnPosition = new Vector3(Random.Range(-10f,1f), 1, Random.Range(-5f,6f));
        int randomIndex = Random.Range(0,trees.Length);
        Instantiate(trees[randomIndex], randomTreeSpawnPosition, Quaternion.identity);
        }
    }


    void CreatePyramid()
    {  
        for(int height = 0; height < stonesRequired; height++)
        {
            int length = stonesRequired - height;
            for (int x = -length; x < length-1; x++)
             {
                for (int z = -length; z < length-1; z++)
                {
                    Vector3 pyramid = new Vector3(x+10, height+.5f, z);
                Instantiate(stones[0], pyramid, Quaternion.identity);  
                }
             }
        }
        
    }
}
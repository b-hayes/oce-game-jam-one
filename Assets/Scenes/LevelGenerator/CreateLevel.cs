using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class CreateLevel : MonoBehaviour
{
    public List<GameObject> LevelPrefabs;
    // Start is called before the first frame update
    public int levelSize = 2; // length of generation
    public int DifficultyModifier = 1;
    public int LevelChunkSize = 10;

    void Start()
    {
        for(var ih= 0; ih<  levelSize; ih++)
        {
              for(var iw = 0; iw < levelSize; iw++)
            {
                Instantiate(getRandomPrefab(), new Vector3(ih * LevelChunkSize, 0, iw * LevelChunkSize), Quaternion.identity);
            }
        }
        
        
    }

    private GameObject getRandomPrefab()
    {
        var total = LevelPrefabs.Count;
        var selector = System.Convert.ToInt32(Random.Range(0, total-1));
        return LevelPrefabs[selector];
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;


public class CreateLevel : MonoBehaviour
{
    public List<GameObject> LevelPrefabs;
    // Start is called before the first frame update
    public int LevelWidth = 1; // length of generation
    public int LevelLength = 4;
    public int DifficultyModifier = 1;

    private Dictionary<int, List<GameObject>> DifficultyList = new Dictionary<int, List<GameObject>>();

    void Start()
    {
       

        if(LevelPrefabs.Count == 0)
        {print("no level chunk prefabs set"); 
        return;
        }

        SortLevelPrefabs();

        Vector3 spawnPosition = this.transform.position;

        for(var il= 0; il< LevelLength; il++)
        {
              for(var iw = 0; iw < LevelWidth; iw++)
            {
                var prefab = getRandomPrefab(DifficultyModifier);
                var props =  prefab.GetComponent<LevelProperties>();
                var w =    props.Width;
                var l =  props.Length;

                Instantiate(prefab, spawnPosition, Quaternion.identity);
                spawnPosition += new Vector3(l, 0, 0);

            }
        }
    }

    private void SortLevelPrefabs()
    {

        foreach (var p in LevelPrefabs)
        {
            var props = p.GetComponent<LevelProperties>();
            if (DifficultyList.ContainsKey(props.DifficultySetting))
            {
                DifficultyList[props.DifficultySetting].Add(p);
            }
            else
            {   var list = new List<GameObject>();
                list.Add(p);
                DifficultyList.Add(props.DifficultySetting,list);
            }
        }
    }
    /// <summary>
    /// Gets a random prefab from the selected difficulty
    /// </summary>
    /// <param name="difficulty"></param>
    /// <returns></returns>
    private GameObject getRandomPrefab(int difficulty)
    {
        var randomDifficulty = System.Convert.ToInt32(Random.Range(0 + (difficulty< 2? 0: difficulty-2) , (difficulty < 1? 1:difficulty) - 0.1f));

        List<GameObject> targetList;

        DifficultyList.TryGetValue(randomDifficulty, out targetList);
        while(targetList== null|| targetList.Count == 0)
        {
            randomDifficulty--;
            DifficultyList.TryGetValue(randomDifficulty, out targetList);
            if (randomDifficulty < 0) return LevelPrefabs[0];//Completely failed, pick the first one 
        }
        var total = (float)targetList.Count-1;
        var selector = System.Convert.ToInt32(Random.Range(0, total-0.1f));

        return targetList[selector];
    }


}

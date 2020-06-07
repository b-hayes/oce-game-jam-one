using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTextUpdate : MonoBehaviour
{
   public GameObject Updateable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( GameManager.pickUpsCollected.ContainsKey("banana")){
        int bananaCount = GameManager.pickUpsCollected["banana"];
        var t = Updateable.GetComponent<Text>();

        t.text = $"You collected {bananaCount.ToString()} bananas! \n Quack Quack - Happy Duck!";
        }
    }
}

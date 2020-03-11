using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelmoving : MonoBehaviour
{
    public Text showLevel;
    public int leveling = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leveling = wallmoving.level;//wallmovingの変数参照
        if (leveling == 10){
            showLevel.text = "LevelMAX";//level10の時、表示を"MAX"にする。
        }else showLevel.text = "Level:" + leveling.ToString();
    }
}

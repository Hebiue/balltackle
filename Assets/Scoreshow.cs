using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreshow : MonoBehaviour
{
    public Text showScore2;
    public int scoring = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoring = wallmoving.point;//wallmovingの変数参照
        showScore2.text = "Score:" + scoring.ToString();
    }
}

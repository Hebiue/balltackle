using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmoving3 : MonoBehaviour
{
    private int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -300){//壁突進と、端っこに行ったときの処理
            a = Random.Range(0, 2);
            transform.position = new Vector3(a * 12 - 6, 20, 0);
        }else{
            transform.position += new Vector3(0, 0, -1.9f);
        }
    }
}

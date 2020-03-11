using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmoving2 : MonoBehaviour
{
    public int selected = 0;
    public int leveled = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        selected = wallmoving.select;//変数常に参照
        leveled = wallmoving.level;
        if (transform.position.z < -300){//壁突進と、端っこに行ったときの処理
            transform.position = new Vector3(selected * -12 + 6, 20,1.1f);//0ならばwall1.x = -6(左),1ならばwall1.x = 6(右)となる。
        }else{
            transform.position += new Vector3(0, 0, -1.9f-leveled*0.8f);
        }

    }
}

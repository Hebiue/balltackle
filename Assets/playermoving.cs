using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermoving : MonoBehaviour
{
    public float speed = 0.36f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 0.5f) {//左右移動
            transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -16){
            transform.position += new Vector3(-speed, 0, 0);
        }

    }
    void OnTriggerEnter(Collider col)//衝突判定
    {
        if (col.gameObject.tag == "wall") 
        {
            SceneManager.LoadScene("gameover");//ゲームオーバーへ飛ばす
        }
    }
}

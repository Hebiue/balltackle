using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class wallmoving : MonoBehaviour
{
    public static int select = 0;//0ならばwall1.x = 6(右),1ならばwall1.x = -6(左)となる。
    public static int point = 0;
    public static int level = 0;
    private int cnt = -1;
    public int e = 0;

    public AudioClip sound1;//得点獲得時の効果音定義
    public AudioClip sound2;//レベルアップ時の効果音定義
    public AudioClip sound3;//BGM定義
    AudioSource audioSource;//効果音出すのに必要2

    public GameObject particle;//クローンするエフェクト1
    //public GameObject targetObject;//gameObjectにtraget(particle systemを代入)

    // Start is called before the first frame update
    void Start()
    {
        point = 0;
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound3);
        e = camaramoving.d;
    }

    //point == 4 || point == 9 || point == 16 || point = 21 || point == 29 || point == 39 || point == 51 || point == 65 || point == 74
    // Update is called once per frame
    void Update()
    {
        if (point > 71 || e == 2) {
            level = 10;
        }else if (point > 59) {
            level = 9;
        }else if (point > 48) {
            level = 8;
        }else if (point > 38) {
            level = 7;
        }else if (point > 29) {
            level = 6;
        }else if (point > 21) {//変数levelへpointを参照して毎フレーム変更
            level = 5;
        }else if (point > 14) {
            level = 4;
        }else if (point > 8) {
            level = 3;
        }else if (point > 3) {
            level = 2;
        }else level=1;

        if (transform.position.z < -300) {//壁突進と、端っこに行ったときの処理
            select = Random.Range(0, 2);
            point = point + 1;//ポイント演算
            cnt = cnt + 1;
            Instantiate(particle, new Vector3(0.5f, -0.3f, -28.5f), Quaternion.identity);//エフェクト表示1
            particle.Play();
            if ((cnt == level + 3 || point == 4) && e == 1) {
                audioSource.PlayOneShot(sound2);//ポイント獲得の効果音
                cnt = 0;
                }else audioSource.PlayOneShot(sound1);//ポイント獲得の効果音
            transform.position = new Vector3(select*12-6, 20,0);
        }else {
            transform.position += new Vector3(0, 0, -1.9f-level*0.8f);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camaramoving : MonoBehaviour
{
    private int b = 1;
    private int c = 0;
    public static int d = 0;//1なら通常、2ならLvMAXでスタート
    AudioSource audioSource;
    public AudioClip sound4;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        d = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (b == 0){
            transform.position += new Vector3(-0.1f, 0, 0);
            if (transform.position.x < -10.0f) {
                b = 3;
            }
        }else if (b == 1) {
            transform.position = new Vector3(10, 20.6f,- 286);
            b = 0;
        }else if (b == 2) {
            transform.position += new Vector3(0, -0.15f, 0);
            if (transform.position.y < 5.5f) {
                b = 1;
            }
        }else if (b == 3) {
            transform.position = new Vector3(0, 36.1f, -286);
            b = 2;
        }

        if (Input.GetKey(KeyCode.Space) && d == 0){
            if (Input.GetKey(KeyCode.M)) {
                c = 0;
                d = 2;
            }else {
                c = 0;
                d = 1;
            }
            audioSource.PlayOneShot(sound4);
        }

        if (c > 50 && d != 0) {
            SceneManager.LoadScene("main");
        }
        c = c + 1;//フレームカウント
    }
}

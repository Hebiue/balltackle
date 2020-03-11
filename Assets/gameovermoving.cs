using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameovermoving : MonoBehaviour
{
    public AudioClip sound2;//効果音出すのに必要な奴1
    AudioSource audioSource;//効果音出すのに必要2

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound2);//死亡効果音
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)){
            SceneManager.LoadScene("main");
        }
        if (Input.GetKey(KeyCode.T)){
            SceneManager.LoadScene("title");
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxmoving : MonoBehaviour
{
    public static int z = 0;
    // Start is called before the first frame update
    void Start()
    {
        z = camaramoving.d;
        transform.position = new Vector3(1300, 620, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (z == 1) {
            transform.position = new Vector3(0, 999, 0);
        }
    }
}

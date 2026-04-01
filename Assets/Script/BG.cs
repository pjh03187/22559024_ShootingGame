using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public Material mBG;
    public float spd = .2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Vector2.up;
        mBG.mainTextureOffset += dir * spd * Time.deltaTime;

            //int a = a + 1; == int a +=
    }
}

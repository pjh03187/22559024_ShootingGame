using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public float spd = 5.0f;
    Vector3 direct = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = transform.position + direct * spd * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}

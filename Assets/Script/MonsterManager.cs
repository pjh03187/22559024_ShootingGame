using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public GameObject prefabsMonster;

    float nowTime;
    float minTime = 1f; //랜덤 최소
    float maxTime = 5f; //랜덤 최대

    public float createTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        // 지정 시간 = 랜덤 시간 (최소,최대)
        createTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        nowTime = nowTime + Time.deltaTime;

        if(nowTime > createTime)
        {
            GameObject monster = Instantiate(prefabsMonster);
            monster.transform.position = transform.position;

            //랜덤 함수 추가
            createTime = Random.Range(minTime, maxTime);

            nowTime = 0f;
            
        }
     
    }
}

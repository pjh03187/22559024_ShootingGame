using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public float spd = 1.0f;
    private GameObject target;
    Vector3 direct = Vector3.down; //아래로
    // Start is called before the first frame update

    public GameObject prefabEx;

    private void Start()
    {
        target = GameObject.Find("Character");
     
        int rndNum = Random.Range(0, 10);
        //transform.position = transform.position + direct * spd * Time.deltaTime;
        //30% 확률 지정
        if(rndNum % 3 == 0) //3의 배수
        {
           
            //해당 확률일 때 일어나는 일을 if문 안에 채운다.
            //target이라는 GameObject (대문자, 소문자 신경쓰기)에 Character넣음
            //GameObject.Find : hierarchy(오브젝트 배치하는 그 칸)에서 GameObject 찾기
            GameObject target = GameObject.Find("Character");
            //두 점 사이의 거리를 구하면 벡터 값으로 방향이 나온다
            //방금 타겟으로 지정한 이유가 두 오브젝트 사이의 [방향을 구하기 위해서]
            direct = target.transform.position - transform.position;
            //벡터의 크기를 1로.
            //왜? Normalize로 벡터의 크기를 1로 만드는가? 방금 구한 [방향만 남기고 거리는 제거]하기위해서
            //[벡터는 크기와 방향을 가지고있으니까!]
            direct.Normalize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direct * spd * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject exTemp = Instantiate(prefabEx);
        exTemp.transform.position = transform.position;
        Destroy(collision.gameObject);
        Destroy(gameObject);
        //순서가 바뀌면 여러 상황에서 꼬일수가있다. 순서를 바꿔도 작동은했었지만, 여러 상황을 대비해서 코드는 순서를 지켜서 쓰도록하자.

    }
}

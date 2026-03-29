using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutLineWall : MonoBehaviour
{
    //Collider 끼리 감지 되었을 때 일어나는 이벤트
    private void OnTriggerEnter(Collider other)
    {
        //Collider GameObject를 파괴함
        Destroy(other.gameObject);
    }
}

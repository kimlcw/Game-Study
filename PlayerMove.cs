using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 초당 15픽셀 이동 속도
    private float moveSpeed = 15.0f;
    Vector3 MoveNextStep;    // 보폭 계산을 위한 변수

    Vector3 MoveHStep;
    Vector3 MoveVStep;

    // 키보드 입력값 변수
    float h, v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 가감속 有 이동
        h = Input.GetAxis("Horizontal");
        // 화살표 좌우키 클릭 => -1.0f ~ 1.0f 사잇값 리턴
        v = Input.GetAxis("Vertical");

        MoveHStep = Vector3.right * h;
        MoveVStep = Vector3.forward * v;

        MoveNextStep = MoveHStep + MoveVStep;
        MoveNextStep = MoveNextStep.normalized * moveSpeed * Time.deltaTime;

        transform.position = transform.position + MoveNextStep;

    }
}

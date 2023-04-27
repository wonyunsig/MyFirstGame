using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public const float moveSpeed = 7.5f; //움직이는 속도 정의
    public bool isTouchTop;
    public bool isTouchBottom;
    public bool isTouchLeft;
    public bool isTouchRight;

    private void Start()
    {
        
    }
    
    private void Update()
    {
        moveControl();
        //캐릭터를 움직이는 함수를 프레임마다 호출
    }

    void moveControl()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //아까 지정한 Axes를 통해 키의 방향을 판단하고 속도와 프레임 판정을 곱해 이동량을 결정
        this.gameObject.transform.Translate(distanceX, 0, 0);
        //이동량만큼 실제로 이동을 반영
        float distanceY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        //아까 지정한 Axes를 통해 키의 방향을 판단하고 속도와 프레임 판정을 곱해 이동량을 결정
        this.gameObject.transform.Translate(0, distanceY, 0);
        //이동량만큼 실제로 이동을 반영
    }
}

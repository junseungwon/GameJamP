using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class CamerSystem : MonoBehaviour
{
    public float moveSpeed = 5f; // 카메라 이동 속도

    void Update()
    {

        //최대가 1080
        // 마우스 위치를 스크린 좌표로 가져옴
        Vector3 mousePosition = Input.mousePosition;

        // 마우스의 Y 좌표가 화면의 바닥 근처인지 확인
        if (mousePosition.y <= 30) // 화면의 하단 10픽셀 이내
        {
            // 카메라의 위치를 아래로 이동
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        if (mousePosition.y >= 1050) // 화면의 하단 10픽셀 이내
        {
            // 카메라의 위치를 아래로 이동
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        Debug.Log(mousePosition);
       
    }
}

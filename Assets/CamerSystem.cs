using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class CamerSystem : MonoBehaviour
{
    public float moveSpeed = 5f; // ī�޶� �̵� �ӵ�

    void Update()
    {

        //�ִ밡 1080
        // ���콺 ��ġ�� ��ũ�� ��ǥ�� ������
        Vector3 mousePosition = Input.mousePosition;

        // ���콺�� Y ��ǥ�� ȭ���� �ٴ� ��ó���� Ȯ��
        if (mousePosition.y <= 30) // ȭ���� �ϴ� 10�ȼ� �̳�
        {
            // ī�޶��� ��ġ�� �Ʒ��� �̵�
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        if (mousePosition.y >= 1050) // ȭ���� �ϴ� 10�ȼ� �̳�
        {
            // ī�޶��� ��ġ�� �Ʒ��� �̵�
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        Debug.Log(mousePosition);
       
    }
}

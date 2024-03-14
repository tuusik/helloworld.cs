using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 2f; // �������� �������� �������
    public float distance = 2f; // ����������, �� ������� ������ ����� ��������� ����� � ����

    private Vector3 startPosition; // ��������� ������� �������

    void Start()
    {
        // ��������� ��������� ������� �������
        startPosition = transform.position;
    }

    void Update()
    {
        // ��������� ����� ������� �� ���������
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * distance;

        // ������������� ����� ������� �������
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 2f; // Скорость движения объекта
    public float distance = 2f; // Расстояние, на которое объект будет двигаться вверх и вниз

    private Vector3 startPosition; // Начальная позиция объекта

    void Start()
    {
        // Сохраняем начальную позицию объекта
        startPosition = transform.position;
    }

    void Update()
    {
        // Вычисляем новую позицию по вертикали
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * distance;

        // Устанавливаем новую позицию объекта
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}


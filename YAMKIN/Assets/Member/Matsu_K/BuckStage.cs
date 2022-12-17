using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuckStage : MonoBehaviour
{
    [Header("�v���C���[")]
    [SerializeField]
    GameObject Player;

    [Header("�w�i1")]
    [SerializeField]
    GameObject Buck1;

    [Header("�w�i1�̈ړ�����")]
    [SerializeField]
    float Distance1;

    [Header("�w�i2")]
    [SerializeField]
    GameObject Buck2;

    [Header("�w�i2�̈ړ�����")]
    [SerializeField]
    float Distance2;

    void Start()
    {

    }

    void Update()
    {
        Buck1.transform.position = new Vector2(Player.transform.position.x / Distance1, Player.transform.position.y / Distance1);
        Buck2.transform.position = new Vector2(Player.transform.position.x / Distance2, Player.transform.position.y / Distance2);
    }
}

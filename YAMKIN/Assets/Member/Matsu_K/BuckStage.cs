using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuckStage : MonoBehaviour
{
    [Header("ƒvƒŒƒCƒ„[")]
    [SerializeField]
    GameObject Player;

    [Header("”wŒi1")]
    [SerializeField]
    GameObject Buck1;

    [Header("”wŒi1‚ÌˆÚ“®‹——£")]
    [SerializeField]
    float Distance1;

    [Header("”wŒi2")]
    [SerializeField]
    GameObject Buck2;

    [Header("”wŒi2‚ÌˆÚ“®‹——£")]
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Stay");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exit");
    }
}

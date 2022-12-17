using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class deptManager : MonoBehaviour
{
    possessionManager pM;

    private TMP_Text valueText;

    [Header("初期借金")]
    [SerializeField]
    private int startMoney = 1000000;
    [Header("割合")]
    [SerializeField]
    private int rate = 20;
    [Header("増えるまでの時間")]
    [SerializeField]
    private float addTime = 5;
    [Header("ゲームオーバー")]
    [SerializeField]
    private int limit = 10000000;

    private float nowTime;

    void Start()
    {
        valueText = transform.Find("DeptManager/ValueText").gameObject.GetComponent<TMP_Text>();
        valueText.text = Mathf.FloorToInt(startMoney).ToString("c");
    }

    void Update()
    {
        nowTime += Time.deltaTime;
        if(nowTime >= addTime)
        {
            nowTime = 0;
            StartCoroutine("addDept");
        }
        if(startMoney >= limit)
        {
            Debug.Log("<color=yellow>Game Over</Color>");
        }
    }

    IEnumerator addDept()
    {
        startMoney += startMoney * rate/100;
        valueText.text = Mathf.FloorToInt(startMoney).ToString("c");
        yield return new WaitForSeconds(addTime);
    }

    public void AddLoan(int loan)
    {
        startMoney += loan;
    }
}

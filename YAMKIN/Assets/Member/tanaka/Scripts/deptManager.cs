using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class deptManager : MonoBehaviour
{
    possessionManager pM;

    private TMP_Text valueText;

    [Header("�����؋�")]
    [SerializeField]
    private int startMoney = 1000000;
    [Header("����")]
    [SerializeField]
    private int rate = 20;
    [Header("������܂ł̎���")]
    [SerializeField]
    private float addTime = 5;
    [Header("�Q�[���I�[�o�[")]
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

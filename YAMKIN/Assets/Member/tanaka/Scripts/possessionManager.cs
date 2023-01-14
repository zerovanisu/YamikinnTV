using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class possessionManager : MonoBehaviour
{
    static public int Money = 0;

    deptManager dM;

    private Text valueText;

    [Header("初期持ち金")]
    [SerializeField]
    private int startMoney = 100000;
    [Header("被ダメージ")]
    [SerializeField]
    private int lostRate = 10000;
    [Header("借入")]
    [SerializeField]
    private int loan = 100000;

    private void Awake()
    {
        Money = startMoney;
    }
    void Start()
    {
        valueText = transform.Find("PossessionManager/ValueText").gameObject.GetComponent<Text>();
        valueText.text = Mathf.FloorToInt(startMoney).ToString("c");
        dM = this.gameObject.GetComponent<deptManager>();
    }

    void Update()
    {
        valueText.text = Mathf.FloorToInt(Money).ToString("c");

        #region デバッグ
        if (Input.GetKeyDown(KeyCode.R))
        {
            Heal();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Damage();
        }
        #endregion
    }

    //ダメージを受けたとき
    public void Damage()
    {
        Money -= lostRate;
    }

    public void Heal()
    {
        Money += loan;
        dM.AddLoan(loan);
    }
}

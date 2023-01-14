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

    [Header("����������")]
    [SerializeField]
    private int startMoney = 100000;
    [Header("��_���[�W")]
    [SerializeField]
    private int lostRate = 10000;
    [Header("�ؓ�")]
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

        #region �f�o�b�O
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

    //�_���[�W���󂯂��Ƃ�
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

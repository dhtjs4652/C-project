using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_Test : MonoBehaviour
{

    // ���� ��, ���, ����ũ, ����, ���� ��ư�� �ش��ϴ� ���� ����
    public Button SkillBtn, WorkBtn, FinTechBtn, BankBtn, SettingBtn;

    // Start is called before the first frame update
    void Start()
    {
        SkillBtn.onClick.AddListener(skill);
        WorkBtn.onClick.AddListener(work);
        FinTechBtn.onClick.AddListener(fintech);
        BankBtn.onClick.AddListener(bank);
        SettingBtn.onClick.AddListener(setting);
    }

    void skill()
    {
        Debug.Log("���� �� ��ư�� Ŭ���ϼ̽��ϴ�.");
    }

    void work()
    {
        Debug.Log("��� ��ư�� Ŭ���ϼ̽��ϴ�.");
    }

    void fintech()
    {
        Debug.Log("����ũ ��ư�� Ŭ���ϼ̽��ϴ�.");
    }

    void bank()
    {
        Debug.Log("���� ��ư�� Ŭ���ϼ̽��ϴ�.");
    }

    void setting()
    {
        Debug.Log("���� ��ư�� Ŭ���ϼ̽��ϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
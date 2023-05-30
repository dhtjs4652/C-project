using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_Test : MonoBehaviour
{

    // 스펙 업, 출근, 재테크, 은행, 설정 버튼에 해당하는 변수 생성
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
        Debug.Log("스펙 업 버튼을 클릭하셨습니다.");
    }

    void work()
    {
        Debug.Log("출근 버튼을 클릭하셨습니다.");
    }

    void fintech()
    {
        Debug.Log("재테크 버튼을 클릭하셨습니다.");
    }

    void bank()
    {
        Debug.Log("은행 버튼을 클릭하셨습니다.");
    }

    void setting()
    {
        Debug.Log("설정 버튼을 클릭하셨습니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
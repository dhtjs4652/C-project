using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    public GameObject OptionPanel;

     void Start()
    {
        OptionPanel.SetActive(false);
    }

    public void OnClickSkill()
    {
        Debug.Log("스펙 업 버튼 클릭");
    }

    public void OnClickWork()
    {
        Debug.Log("출근 버튼 클릭");
    }

    public void OnClickTech()
    {
        Debug.Log("재테크 버튼 클릭");
    }

    public void OnClickBank()
    {
        Debug.Log("은행 버튼 클릭");
    }
    public void OnClickOption()
    {
        Debug.Log("설정 버튼 클릭");
        OptionPanel.SetActive(true);
    }

    public void OnClickOptionQuick()
    {
        OptionPanel.SetActive(false);
    }

    public void OnClickReset()
    {
        Debug.Log("초기화 버튼 클릭");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // GameObject에서 OptionPanel 불러옴
    public GameObject OptionPanel;

     void Start()
    {
        // 게임 시작했을 때 OptionPanel 화면에 안보이게 false처리
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
        // 설정 버튼 클릭했을 때 OptionPanel이 보이도록 true처리
        OptionPanel.SetActive(true);
    }

    public void OnClickOptionQuick()
    {
        // 설정창에서 닫기 버튼을 클릭하면 OptionPanel이 안보이도록 다시 false처리
        OptionPanel.SetActive(false);
    }

    public void OnClickReset()
    {
        Debug.Log("초기화 버튼 클릭");
    }
}

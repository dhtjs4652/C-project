using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSkill()
    {
        Debug.Log("스펙 업 버튼을 클릭하셨습니다.");
    }

    public void OnClickWork()
    {
        Debug.Log("출근 버튼을 클릭하셨습니다.");
    }

    public void OnClickTech()
    {
        Debug.Log("재테크 버튼을 클릭하셨습니다.");
    }

    public void OnClickBank()
    {
        Debug.Log("은행 버튼을 클릭하셨습니다.");
    }

    public void OnClickOption()
    {
        Debug.Log("설정 버튼을 클릭하셨습니다.");
    }
}
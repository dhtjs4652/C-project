using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateSlider : MonoBehaviour
{
    public Slider date;
    public Text dateText;

    // 슬라이더가 얼마나 빠르게 채워지는지 조절하는 변수
    public float fillSpeed = 0.1f;
    private DateTime currentDate;

    void Start()
    {
        currentDate = DateTime.Now;
        UpdateDateText();
    }

    void Update()
    {
        if (date.value < 1)
        {
            date.value += fillSpeed * Time.deltaTime;
        }

        else
        {
            currentDate = currentDate.AddDays(1);
            UpdateDateText();
            // 슬라이더 값을 0으로 초기화하여 반복될 수 있도록
            date.value = 0;
        }
    }

    private void UpdateDateText()
    {
        dateText.text = currentDate.ToString("yyyy년 MM월 dd일 dddd");
    }
}

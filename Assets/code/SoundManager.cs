using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // AudioSource를 public 변수로 선언
    public AudioSource musicsource;
    public AudioSource btnsource;

    // 인수를 받아서 오디오 소스의 볼륨을 조절해 주는 역할 함수
    public void SetMusicVolume(float volume)
    {
        musicsource.volume = volume;
    }

    // 버튼음 볼륨을 조절해주는 역할 함수
    public void SetButtonVolume(float volume)
    {
        btnsource.volume = volume;
    }

    // 오디오를 재생하는 함수
    public void OnSfx()
    {
        btnsource.Play();
    }
}


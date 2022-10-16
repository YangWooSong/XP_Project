using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //�ð� 15�� ���� ����
    private float timeDuration ;         //�ִ� �ð�
    private float timer;

    [SerializeField]
    private TextMeshProUGUI firstMinute;
    [SerializeField]
    private TextMeshProUGUI secondMinute;
    [SerializeField]
    private TextMeshProUGUI seperator;
    [SerializeField]
    private TextMeshProUGUI firstSecond;
    [SerializeField]
    private TextMeshProUGUI secondSecond;

    private void Awake()
    {
        
    }
    void Start()
    {
        //Ÿ�̸� �ð� ����
        
        
    }
    void Update()
    {
        timeDuration = MainGameManagerScr.timeLimit;
        ResetTimer();
        if (timer > 11f)
        {
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        }
        //10�ʺ��� ���������� ��ȯ
        else if (timer >= 0f)
        {
            ColorChange();
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        }
        //Ÿ�̸Ӱ� ������ ��� ����
        if (timer < 0f)
        {
            timer = 0;
            UpdateTimerDisplay(timer);
        }
    }

    //�ð� �ʱ�ȭ �Լ�
    private void ResetTimer()
    {
        timer = timeDuration;
    }

    //�� ��ȯ �Լ�
    private void ColorChange()
    {
        firstMinute.color = Color.red;
        secondMinute.color = Color.red;
        seperator.color = Color.red;
        firstSecond.color = Color.red;
        secondSecond.color = Color.red;
    }

    //���ڸ� ȭ�鿡 ���� �Լ�
    private void UpdateTimerDisplay(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        firstMinute.text = currentTime[0].ToString();
        secondMinute.text = currentTime[1].ToString();
        firstSecond.text = currentTime[2].ToString();
        secondSecond.text = currentTime[3].ToString();
    }
}

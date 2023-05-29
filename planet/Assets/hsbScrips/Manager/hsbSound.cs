using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hsbSound : MonoBehaviour
{
    public AudioSource audioSource;

    public double startTime;

    public double delayInSeconds = 3.0;     // ���� 3�� �ڿ� �����ϵ���

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        startTime = AudioSettings.dspTime;
        audioSource.PlayScheduled(startTime + delayInSeconds);
    }
}

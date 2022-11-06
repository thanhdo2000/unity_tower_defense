using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float totalSeconds = 0;
    float elapsedSeconds = 0;

    bool running = false;
    bool started = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (running)
        {
            elapsedSeconds += Time.deltaTime;
            if (elapsedSeconds >= totalSeconds)
            {
                running = false;
            }
        }
    }

    public bool Finished
    {
        get
        {
            return started && !running;
        }
    }

    public bool Running
    {
        get
        {
            return running;
        }
    }

    public void Run()
    {
        if (totalSeconds > 0)
        {
            started = true;
            running = true;
            elapsedSeconds = 0;
        }
    }

    public float Duration
    {
        set
        {
            if (!running)
            {
                totalSeconds = value;
            }
        }
    }
}

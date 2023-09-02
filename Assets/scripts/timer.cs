using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class timer : MonoBehaviour
{  //extra options choosing to countdown then gameover or to countup to check how much time it took to finish the puzzle
    [Header("component")]
    public TextMeshProUGUI timerText;
    [Header("timer settings")]
    public float currentTime;
    public bool countdown;

    [Header("limit settings")]
    public bool haslimit;
    public float timerlimit;

    void Start()
    {}

    // Update is called once per frame
    void Update()
    {
        currentTime = countdown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
       if (haslimit && ((countdown && currentTime <= timerlimit) || (!countdown && currentTime >=timerlimit)))
        {
            settimertext();
            enabled = false;
            SceneManager.LoadSceneAsync("lose");

        }
       settimertext();
            
    }

    private void settimertext()
    {
        timerText.text = currentTime.ToString("0");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class changecoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        // SetCoinsText(134234123);
        // SetCoinsText(134234);
        // SetCoinsText(1000);
        // SetCoinsText(12);
        TimeApiClient.GetCurrentTimeAsync();
    }

    public void SetCoinsText (int value){
        if(value >= 1000000000){
            Debug.Log("Max");
        }
        else if(value >= 1000000){
            Debug.Log(string.Format("{0}.{1}M", (value/1000000), GetFirstDigitFromNumber(value % 1000000)));
        }
        else if(value >= 1000){
            Debug.Log(string.Format("{0}.{1}K", (value/1000), GetFirstDigitFromNumber(value % 1000)));
        }else{
            Debug.Log(value.ToString());
        }
    }
    int GetFirstDigitFromNumber (int value){
        return int.Parse(value.ToString()[0].ToString());
    }
}
public static class TimeApiClient
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task<DateTime> GetCurrentTimeAsync()
    {
        var response = await client.GetAsync("https://timeapi.io/api/Time/current");
        response.EnsureSuccessStatusCode();
        var currentTimeString = await response.Content.ReadAsStringAsync();
        var currentTime = DateTime.Parse(currentTimeString);
        Debug.Log(currentTime.ToString("yyyy-MM-dd HH:mm:ss"));
        return currentTime;
    }
}
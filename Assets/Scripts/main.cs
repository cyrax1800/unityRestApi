using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class main : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onBtnClick()
    {
        RestApi api = new RestApi.Builder()
                        .baseUrl("https//localhost.com")
                        .build();
        Call<string> call = api.create<testInterface>().todo();
        call.enqueue(new CallBack<string>
        {
            onResponse = (request, response) => { Debug.Log(response.body); },
            onFailed = (request, exception) => { }
        });

        Debug.Log("\nDone");
    }
}

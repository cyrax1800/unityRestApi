using UnityEngine;

public class Call<T>
{
    public void enqueue(CallBack<T> callback)
    {
        object a = "asd";
        Response<T> response = new Response<T>((T)a);
        callback.onResponse(this, response);
    }
}
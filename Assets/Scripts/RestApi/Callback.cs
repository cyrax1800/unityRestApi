using System;

public class CallBack<T>
{

    public Action<Call<T>, Response<T>> onResponse;
    public Action<Call<T>, Exception> onFailed;

}
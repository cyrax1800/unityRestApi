public interface testInterface
{
    [GET("/take")]
    Call<string> todo();
}
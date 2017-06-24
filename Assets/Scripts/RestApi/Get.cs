using System;

public class GET : Attribute
{
    private string path;

    public GET(string path)
    {
        this.Path = path;
    }

    public string Path { get; private set; }
}
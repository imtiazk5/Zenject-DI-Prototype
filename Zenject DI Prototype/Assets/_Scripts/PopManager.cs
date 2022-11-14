
using UnityEngine;

public interface IPopManager
{
    public void PopMessage(string s);
}

public class PopManager : IPopManager
{
   
    public void PopMessage(string message)
    {
        Debug.Log(message);
    }



}

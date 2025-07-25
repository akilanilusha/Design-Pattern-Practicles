using System;

namespace singelton;

public class Singelton
{
    private static Singelton _instance=null;

    private Singelton() { }
    
    public static Singelton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singelton();
            }
            return _instance;
        }
    }
}

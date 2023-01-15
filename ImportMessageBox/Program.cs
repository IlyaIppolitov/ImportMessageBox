using ImportMessageBox;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Application
{
    public static void Main()
    {
        //Эта функция будет вызвана из DLL User32.dll
        if (WinApiFunctions.MessageBox(0, "Выхотите полететь на Марс?", "Полёт",
                                        WinApiFunctions.Constants.MB_YESNO | WinApiFunctions.Constants.MB_ICONQUESTION) == WinApiFunctions.Constants.IDYES)
        {
            WinApiFunctions.MessageBox(0, "Обратитесь к Илону!", "Полёт", 0);
        }
    }
}
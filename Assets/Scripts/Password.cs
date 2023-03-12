using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    private Final myFinal;

    private string finalPassword;
    private int passwordLength;
    private string password = "";

    public bool passwordActive = false;
    public void SetPassword(string sol)
    {
        finalPassword = sol;
        passwordLength = sol.Length;
    }

    public bool CheckPassword()
    {
        return (password == finalPassword);
    }

    private void ResetPassword()
    {
        password = "";
    }
    public void AddCharacter(string letter)
    {
        if (passwordActive)
        {
            password += letter;

            // Habiendo alcanzado la longitud requerida
            if (password.Length == passwordLength)
            {
                if (CheckPassword())
                {
                    // Win effect
                    SoundManager.instance.PlayEffect(4, 1.0f);
                    myFinal.PasswordAccepted();
                }
                else
                {
                    // Lose effect
                    SoundManager.instance.PlayEffect(5, 2.0f);
                    ResetPassword();
                }
            }

        }
    }

    public void AttachFinal(Final fin)
    {
        myFinal = fin;
    }
}

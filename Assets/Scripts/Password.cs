using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    private Final myFinal;
    private Final myFinal2;

    [SerializeField] private string finalPassword;
    [SerializeField] private string finalPassword2;
    [SerializeField] private TextMeshPro text;

    private int passwordLength;
    private string password = "";

    public bool passwordActive = true;
    public void SetPassword(string sol)
    {
        finalPassword = sol;
        passwordLength = sol.Length;
    }
    public void SetPassword2(string sol)
    {
        finalPassword2 = sol;
    }


    public bool CheckPassword()
    {
        return (password == finalPassword);
    }
    public bool CheckPassword2()
    {
        return (password == finalPassword2);
    }

    private void ResetPassword()
    {
        password = "";
        text.text = "";
    }
    public void AddCharacter(string letter)
    {
        if (passwordActive)
        {
            password += letter;
            text.text += '*';
            // Habiendo alcanzado la longitud requerida
            if (password.Length == passwordLength)
            {
                if (CheckPassword())
                {
                    // Win effect
                    SoundManager.instance.PlayEffect(4, 1.0f);
                    myFinal.PasswordAccepted();
                }
                else if (CheckPassword2())
                {
                    SoundManager.instance.PlayEffect(4, 1.0f);
                    myFinal2.PasswordAccepted();
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

    public void AttachFinalColores(Final fin)
    {
        myFinal2 = fin;
    }
}

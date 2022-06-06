using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowPattern : MonoBehaviour
{
    public float RainbowSmoothness = 3f;
    public Material Mat;
    private Color Emiss;
    private Color currentColor;
    private Color nextColor;
    private bool ChangeEmiss;
    
    
     void Start()
    {
        ChangeEmiss = true;
        nextColor = new Color(0f, 0f, 0f, 0f);  // just so the alpha parameter is initialized as zero
        currentColor = Mat.GetColor("Color_E86DA286");
        Mat.SetColor("Color_E86DA286", new Color(2f, 0, 0, 0));
        Wait();
    }



    void Update()
    {
        currentColor = Mat.GetColor("Color_E86DA286");  // Gets the current color

        if (currentColor.r > 1.9f && currentColor.r < 2.1f && currentColor.g > -0.1f && currentColor.g < 0.1f && currentColor.b > -0.1f && currentColor.b < 0.1f)    // de vermelho para roxo
        {
            nextColor.r = 2f; nextColor.g = 0f; nextColor.b = 2f;
            if (ChangeEmiss == true)
            {
                Emiss = Mat.GetColor("Color_E86DA286");
                ChangeEmiss = false;
            }
        }
        else if (currentColor.r > 1.9f && currentColor.r < 2.1f && currentColor.g > -0.1f && currentColor.g < 0.1f && currentColor.b > 1.9f && currentColor.b < 2.1f) // de roxo para azul
        {
            nextColor.r = 0f; nextColor.g = 0f; nextColor.b = 2f;
            if (ChangeEmiss == true)
            {
                Emiss = Mat.GetColor("Color_E86DA286");
                ChangeEmiss = false;
            }
        }
        else if (currentColor.r > -0.1f && currentColor.r < 0.1f && currentColor.g > -0.1f && currentColor.g < 0.1f && currentColor.b > 1.9f && currentColor.b < 2.1f) // de azul para água
        {
            nextColor.r = 0f; nextColor.g = 2f; nextColor.b = 2f;
            if (ChangeEmiss == true)
            {
                Emiss = Mat.GetColor("Color_E86DA286");
                ChangeEmiss = false;
            }
        }
        else if (currentColor.r > -0.1f && currentColor.r < 0.1f && currentColor.g > 1.9f && currentColor.g < 2.1f && currentColor.b > 1.9f && currentColor.b < 2.1f) // de água para verde
        {
            nextColor.r = 0f; nextColor.g = 2f; nextColor.b = 0f;
            if (ChangeEmiss == true)
            {
                Emiss = Mat.GetColor("Color_E86DA286");
                ChangeEmiss = false;
            }
        }
        else if (currentColor.r > -0.1f && currentColor.r < 0.1f && currentColor.g > 1.9f && currentColor.g < 2.1f && currentColor.b > -0.1f && currentColor.b < 0.1f) // de verde para amarelo
        {
            nextColor.r = 2f; nextColor.g = 2f; nextColor.b = 0f;
            if (ChangeEmiss == true)
            {
                Emiss = Mat.GetColor("Color_E86DA286");
                ChangeEmiss = false;
            }
        }
        else if (currentColor.r > 1.9f && currentColor.r < 2.1f && currentColor.g > 1.9f && currentColor.g < 2.1f && currentColor.b > -0.1f && currentColor.b < 0.1f) // de amarelo para vermelho
        {
            nextColor.r = 2f; nextColor.g = 0f; nextColor.b = 0f;
            if (ChangeEmiss == true)
            {
                Emiss = Mat.GetColor("Color_E86DA286");
                ChangeEmiss = false;
            }
        }
        else ChangeEmiss = true;
        Mat.SetColor("Color_E86DA286", Color.Lerp(Emiss, nextColor, RainbowSmoothness * Time.deltaTime));
        Debug.Log(ChangeEmiss);
    }



    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
    }
    /*public void ChangeColor(Color emiss)
    {
        Color nextColor = new Color(0f,0f,0f,0f);  // just so the alpha parameter is initialized as zero

        if(emiss.r == 191f && emiss.g == 0 && emiss.b == 0)    // de vermelho para roxo
        {
            nextColor.r = 191f; nextColor.g = 0f; nextColor.b = 191f;
        }
        else if(emiss.r == 191f && emiss.g == 0f && emiss.b == 191f) // de roxo para azul
        {
            nextColor.r = 0f; nextColor.g = 0f; nextColor.b = 191f;
        }
        else if(emiss.r == 0f && emiss.g == 0f && emiss.b == 191f) // de azul para água
        {
            nextColor.r = 0f; nextColor.g = 191f; nextColor.b = 191f;
        }
        else if (emiss.r == 0f && emiss.g == 191f && emiss.b == 191f) // de água para verde
        {
            nextColor.r = 0f; nextColor.g = 191f; nextColor.b = 0f;
        }
        else if (emiss.r == 0f && emiss.g == 191f && emiss.b == 0f) // de verde para amarelo
        {
            nextColor.r = 191f; nextColor.g = 191f; nextColor.b = 0f;
        }
        else if (emiss.r == 191f && emiss.g == 191f && emiss.b == 0f) // de amarelo para vermelho
        {
            nextColor.r = 191f; nextColor.g = 0f; nextColor.b = 0f;
        }
        emiss = Color.Lerp(emiss, nextColor, RainbowSmoothness * Time.deltaTime);
    }*/
}

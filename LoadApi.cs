using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnhollowerRuntimeLib;
using UnityEngine.Events;

namespace RoseClient.SDK.Load
{
    public class LoadButton
    {
        public static GameObject Buttonbase;
        public static Text Label;
        public static List<LoadButton> Allbutton = new List<LoadButton>();
        public static GameObject Button;
        public static string APINAME = "-LimesApi";
        public LoadButton(Vector3 Position, Vector3 Scale, string ButtonText, string ObjName, Action action, Color LabelColor, Color ButtonColor, Sprite Buttonimage = null)
        {
            Buttonbase = UnityEngine.Object.Instantiate(LoadButtonExtensions.LoadButtonTemplate(), LoadButtonExtensions.LoadButtonTemplate().transform.parent);
            Buttonbase.name = ObjName + APINAME;
            Buttonbase.GetComponent<RectTransform>().localPosition = Position;
            Buttonbase.GetComponent<RectTransform>().localRotation = Quaternion.identity;
            Buttonbase.GetComponent<RectTransform>().localScale = Scale;
            Button = Buttonbase.transform.Find("GoButton").gameObject;
            Button.GetComponent<Image>().color = ButtonColor;
            Button.GetComponent<Image>().overrideSprite = Buttonimage;
            Label = Button.transform.Find("Text").gameObject.GetComponent<Text>();
            Label.text = ButtonText;
            Label.color = LabelColor;
            Buttonbase.transform.Find("Decoration_Left").gameObject.SetActive(false);
            Buttonbase.transform.Find("Loading Elements").gameObject.SetActive(false);
            Buttonbase.transform.Find("Decoration_Right").gameObject.SetActive(false);
            Buttonbase.transform.Find("Panel_Backdrop").gameObject.SetActive(false);
            Allbutton.Add(this);
            Button.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
            if (action != null)
            {
                Button.GetComponent<Button>().onClick.AddListener(UnhollowerRuntimeLib.DelegateSupport.ConvertDelegate<UnityAction>(action));
            }
            
        }

    }
    public static class LoadButtonExtensions
    {
        public static GameObject LoadScreen1 = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/");
        public static GameObject LoadScreen2 = GameObject.Find("UserInterface/LoadingBackground_TealGradient_Music");
        public static GameObject LoadButtonTemplate()
        {
            while (LoadScreen1 == null) return null;
            GameObject ButtonTemp = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress");
            return ButtonTemp;
        }     
    }
}

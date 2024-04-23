using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class listpractice : MonoBehaviour
{

    void Start()
    {
        List<string> mylist = new();
        mylist.Add("aa");
        mylist.Add("bb");
        mylist.Add("cc");    // ("aa","bb","cc")

        mylist.Insert(0, "xx");   // ("xx","aa","bb","cc")
        mylist.Insert(2, "yy");   // ("xx","aa", "yy","bb","cc")


        mylist.Remove("yy");
    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

struct A: IEquatable<A>
{
    public int a;
    public A( int a )
    {
        this.a = a;
    }

    public bool Equals(A other)
    {
        return this.a == other.a;
    }
 /*   public override int GetHashCode()
{
        return a;
}*/
}

public class GameMain : MonoBehaviour {

    private Dictionary<A, int> dic;
    private int n = 0;
	// Use this for initialization
	void Start () {
        dic = new Dictionary<A, int>( 10000 );
	}
	
	// Update is called once per frame
	void Update () {
        if(n++ >= 10000)
        {
            dic.Clear();
            n = 0;
        }
        var a = new A(n);
        //a.a = 1;
        //dic.Add(a, 1);
       // a.GetHashCode();
	}
}

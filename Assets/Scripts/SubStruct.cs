 using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public struct subStructs
{
    public List<subStruct> subStructList;
    public subStructs(List<subStruct> subStructList)
    {
        this.subStructList = subStructList;
    }
}
[System.Serializable]

public struct subStruct : IComparable<subStruct>
{
    public string name;
    
    public Color color;
    public Transform transform;


    public int CompareTo(subStruct other)
    {
        return this.name.CompareTo(other.name);
    }

}
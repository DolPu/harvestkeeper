using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class PlayerBattleData
{
    public FloatData[] dataArray;

    [CanBeNull]
    public FloatData GetData(DataType dataType)
    {
        foreach (var floatData in dataArray)
        {
            if (floatData.dataType == dataType)
            {
                return floatData;
            }
        }
        return null;
    }
}

[Serializable]
public class FloatData
{
    public DataType dataType;

    [SerializeField]
    private float value;
    public float Value
    {
        get => value;
        set
        {
            if (this.value == value)
            {
                return;
            }
            this.value = value;
            OnValueChanged?.Invoke(this.value);
        }
    }

    // Nen co 1 interface de add va remove event
    public Action<float> OnValueChanged;

    public FloatData(DataType dataType, float value)
    {
        this.dataType = dataType;
        this.value = value;
    }
}

[Serializable]
public class Data<T>
{
    public DataType dataType;

    [SerializeField]
    private T value;
    public T Value
    {
        get => value;
        set
        {
            if (this.value.Equals(value))
            {
                return;
            }
            this.value = value;
            OnValueChanged?.Invoke(this.value);
        }
    }

    // Nen co 1 interface de add va remove event
    public Action<T> OnValueChanged;

    public Data(DataType dataType, T value)
    {
        this.dataType = dataType;
        this.value = value;
    }
}
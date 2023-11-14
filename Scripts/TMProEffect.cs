using System.Collections.Generic;
using UnityEngine;

public abstract class TMProEffect : ScriptableObject, ITMProEffect
{
    public abstract void Apply(ref CharData charData);
    public abstract void SetParameters(Dictionary<string, string> parameters);
    public abstract bool ValidateParameters(Dictionary<string, string> parameters);
    public abstract void ResetVariables();

    public abstract void SetParameter<T>(string name, T value);
}

public abstract class TMProEffectParameterless : TMProEffect
{
    public override void SetParameters(Dictionary<string, string> parameters) { }
    public override bool ValidateParameters(Dictionary<string, string> parameters) => true;
    public override void SetParameter<T>(string name, T value) { }
}

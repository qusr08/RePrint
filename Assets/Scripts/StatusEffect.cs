using UnityEngine;

public class StatusEffect
{
	/// <summary>
	/// The current stack of this status effect
	/// </summary>
	public int Stack { get => _stack; set => _stack = value; }
	private int _stack;

	public StatusEffect (int stack)
	{
		Stack = stack;
	}
}

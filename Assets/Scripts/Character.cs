using UnityEngine;

public class Character : Entity
{
	/// <summary>
	/// The amount of chain that this character has currently stored
	/// </summary>
	public int Chain { get => _chain; private set => _chain = value; }
	private int _chain;

	/// <summary>
	/// The amount of Zenny this character has
	/// </summary>
	public int Zenny { get => _zenny; private set => _zenny = value; }
	private int _zenny;
}

using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
	/// <summary>
	/// The health of this entity
	/// </summary>
	public int Health { get => _health; private set => _health = value; }
	private int _health;

	/// <summary>
	/// The amount of action points this entity has
	/// </summary>
	public int ActionPoints { get => _actionPoints; private set => _actionPoints = value; }
	private int _actionPoints;

	/// <summary>
	/// A list of the actions that this entity has
	/// </summary>
	public List<Action> Actions { get => _actions; private set => _actions = value; }
	private List<Action> _actions;

	/// <summary>
	/// The maximum number of actions allowed for this entity
	/// </summary>
	public int ActionLimit { get => Actions.Capacity; private set => Actions.Capacity = value; }

	/// <summary>
	/// A list of the current status effects applied to this entity
	/// </summary>
	public List<StatusEffect> StatusEffects { get => _statusEffects; private set => _statusEffects = value; }
	private List<StatusEffect> _statusEffects;

	/// <summary>
	/// Deal damage to this entity
	/// </summary>
	/// <param name="damage">The amount of damage to deal</param>
	/// <param name="appliedEffects">Optional status effects to apply to the enemy</param>
	public void Damage (int damage, List<StatusEffect> appliedEffects = null)
	{
		Health -= damage;

		if (appliedEffects != null)
			ApplyStatusEffects(appliedEffects);
	}

	/// <summary>
	/// Perform a specific action 
	/// </summary>
	/// <param name="actionIndex"></param>
	/// <returns></returns>
	public bool PerformAction (int actionIndex)
	{
		if (actionIndex < 0 || actionIndex >= Actions.Count)
			return false;

		return Actions[actionIndex].Perform( );
	}

	/// <summary>
	/// Apply a list of status effects to this entity
	/// </summary>
	/// <param name="appliedEffects">The list of status effects to apply</param>
	public void ApplyStatusEffects (List<StatusEffect> appliedEffects)
	{
		bool appliedEffect = false;

		for (int i = 0; i < appliedEffects.Count; i++)
		{
			appliedEffect = false;

			for (int j = 0; j < StatusEffects.Count; j++)
			{
				if (StatusEffects[j].GetType( ) == appliedEffects[i].GetType( ))
				{
					StatusEffects[j].Stack += appliedEffects[i].Stack;

					appliedEffect = true;
					break;
				}
			}

			if (!appliedEffect)
				StatusEffects.Add(appliedEffects[i]);
		}
	}
}
